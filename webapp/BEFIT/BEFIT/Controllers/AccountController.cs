using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Reporting;
using BEFIT.Data;
using BEFIT.Models;
using BEFIT.ViewModels.Account;
using BEFIT.ViewModels.Register;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MimeKit;
namespace BEFIT.Controllers
{
    
    public class AccountController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly RoleManager<Role> roleManager;
        private BEFITContext _context;
        private readonly IHostingEnvironment hostingEnvironment;


        public UsersService usersService = new UsersService();

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager,
            BEFITContext context, RoleManager<Role>roleManager, IHostingEnvironment iHostingEnv)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            hostingEnvironment = iHostingEnv;
            _context = context;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }
   
        [HttpGet]
        [Authorize(Roles = "Admin, Trener")]
        public IActionResult Register()
        {
            var genders = _context.Gender.ToList();
            var model = new RegisterViewModel
            {
                Genders = genders
            };

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Admin, Trener")]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            var emailCheck = _context.Users.SingleOrDefault(c => c.Email == model.Email);

            if (ModelState.IsValid && emailCheck == null)
            {
                Gender g = _context.Gender.SingleOrDefault(c => c.Name == model.MyGender);
                var username = model.Firstname.ToLower() + "." + model.LastName.ToLower();
                var usernameCheck = _context.Users.SingleOrDefault(c => c.UserName == username);
                if(usernameCheck != null)
                {
                    Random rnd = new Random();
                    int month = rnd.Next(1, 13);
                    username += month;
                }

                var user = new User
                {
                    Firstname = model.Firstname,
                    Lastname = model.LastName,
                    UserName = username,
                    Email = model.Email,
                    PhoneNumber = model.Phone,
                    Birthdate = model.Birthdate,
                    Certificate = model.Certificate,
                    DateOfGettingCertificate = model.DateOfGettingCertificate,
                    DateOfRegister =  DateTime.Now,
                    MembershipPrice = model.Student ? 25 : 40,
                    Student = model.Student,
                    DateOfMembershipPayment = DateTime.Now.AddDays(30),
                    Gender = g
                                     
                };
                var result = await userManager.CreateAsync(user, model.Password);
                
                if (result.Succeeded)
                {
                    //Kreiranje tokena za potvrdu identiteta
                    var token = await userManager.GenerateEmailConfirmationTokenAsync(user);
                    var confirmationLink = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, token = token }, Request.Scheme);
                    //logger.Log(LogLevel.Warning, confirmationLink);

                    var role = await roleManager.FindByNameAsync(model.RoleName);
                    if(role != null)
                    {
                        await userManager.AddToRoleAsync(user, role.Name);
                    }
                    ViewBag.ErrorTitle = "Registracija kompletirana";
                    ViewBag.ErrorMessage = "Prije logiranja na račun, potrebno je potvrditi email adresu klikom na link u Inboxu.";
                    ViewBag.ConfirmationLink = confirmationLink;
                   

                    //Slanje emaila za potvrdu identiteta
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Potvrda profila", "befitapp@outlook.com"));
                    message.To.Add(new MailboxAddress(model.Email, model.Email));
                    message.Subject = "Potvrdite vaš profil";
                    var bodyBuilder = new BodyBuilder();
                    bodyBuilder.HtmlBody = "<div style='text-align:center; display:block;'><h1 style='text-align:center; font-weight:400;'>Potvrdite vaš profil</h1><br><p style='text-align:center;'>Klikom na sljedeći link, potvrđujete svoj identitet na aplikaciji BEFIT.</p><br><a href="+confirmationLink+">Potvrđujem svoj identitet</a></div>";

                                     message.Body = bodyBuilder.ToMessageBody();

                    using (var client = new SmtpClient())
                    {
                        client.Connect("smtp-mail.outlook.com", 587, false);
                        client.Authenticate("befitapp@outlook.com", "Befit!123");
                        client.Send(message);
                        client.Disconnect(true);

                    }
                    return View("Message");
                }
            }

            var genders = _context.Gender.ToList();
            model.Genders = genders;
            return View(model);
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if(userId == null || token == null)
            {
                return RedirectToAction("Index", "Notification");
            }
            var user = await userManager.FindByIdAsync(userId);
            if(user == null)
            {
                return StatusCode(418);
            }
            var res = await userManager.ConfirmEmailAsync(user, token);
            if (res.Succeeded)
            {
                return View();
            }
            ViewBag.ErrorMessage = "Email ne može da se potvrdi.";
            return View("Message");
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("login", "account");
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
             
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(model.Username);
                if(user != null && !user.EmailConfirmed && (await userManager.CheckPasswordAsync(user, model.Password)))
                {
                    ModelState.AddModelError(string.Empty, "Email nije potvrđen");
                    return View(model);
                }

                var result = await signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Notification");
                }
                if (result.IsLockedOut)
                {
                    return View("AccountLocked");
                }

                ModelState.AddModelError(string.Empty, "Username ili šifra nisu tačni");
            }


            return View(model);
        }

        [Authorize(Roles = "Admin, Trener")]
        [HttpGet]
        public IActionResult Users()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Profile(string id)
        {
            var user = _context.Users.Include(c => c.Gender).SingleOrDefault(c => c.Id == id);
            if (user == null)
                return StatusCode(418);
            var roles = await userManager.GetRolesAsync(user);

            var logged = await userManager.GetUserAsync(HttpContext.User);
            var loggedRoles = await userManager.GetRolesAsync(logged);
            bool isAuth = loggedRoles[0] == "Clan" ? false : true;
            
            var model = new ProfileViewModel
            {
                User = user,
                Roles = roles,
                isAuthorized = isAuth
            };
            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Profile(ProfileViewModel model, string submitButton, string id)
        {
            //Ako se klikne na dugme Potvrdi, spašavaju se novi podaci i spremaju u bazu
            if (submitButton.Equals("Potvrdi"))
            {
                var user = _context.Users.SingleOrDefault(c => c.Id == id);
                if (user == null)
                    return StatusCode(418);
                var role = await userManager.GetRolesAsync(user);
                if(role[0] != model.RoleName)
                {
                    await userManager.RemoveFromRoleAsync(user, role[0]);
                    await userManager.AddToRoleAsync(user, model.RoleName);
                }
                user.Firstname = model.Firstname;
                user.Lastname = model.Lastname;
                user.Email = model.Email;
                user.PhoneNumber = model.PhoneNumber;
                user.DateOfMembershipPayment = model.DateOfMembershipPayment;
                user.Student = model.Student;
                user.Birthdate = model.Birthdate;
                user.MembershipPrice = model.Student ? 25 : 40;
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            //Ako se klikne na dugme Obriši, briše se sve vezano za istog korisnika
            else if (submitButton.Equals("Obrisi"))
            {
                var user = _context.Users.SingleOrDefault(c => c.Id == id);
                if (user == null)
                    return StatusCode(418);

                var trainings = _context.Training.ToList();            
                var trainingsFiltered = trainings.FindAll(c => c.UserID == user.Id || c.AuthorID == user.Id);
                for (int i = 0; i < trainingsFiltered.Count; i++)
                {
                    _context.Training.Remove(trainingsFiltered[i]);
                }

                var nutritions = _context.Nutrition.ToList();
                var nutritionFiltered = nutritions.FindAll(c => c.UserID == user.Id);
                for (int i = 0; i < nutritionFiltered.Count; i++)
                {
                    _context.Nutrition.Remove(nutritionFiltered[i]);
                }

                var deletedUserRole = await userManager.GetRolesAsync(user);
                var deletedUser = new DeletedUser
                {
                    Name = user.Firstname,
                    Lastname = user.Lastname,
                    DateDeleted = DateTime.Now,
                    DateRegistered = user.DateOfRegister,
                    RoleName = deletedUserRole[0],
                    Email = user.Email
                };

                _context.DeletedUser.Add(deletedUser);
                _context.Users.Remove(user);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Security(string id)
        {
            var model = new SecurityViewModel
            {
                UserID = id
            };
            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Security(string id, SecurityViewModel model)
        {
            var user = _context.Users.SingleOrDefault(c => c.Id == id);
            if (user == null)
                return StatusCode(418);
            if (ModelState.IsValid)
            {

                var token = await userManager.GeneratePasswordResetTokenAsync(user);
                await userManager.ResetPasswordAsync(user, token, model.NewPassword);
                
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult AdminChangePassword()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AdminChangePassword(string id, AdminChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.Users.SingleOrDefault(c => c.Id == id);
                if (user == null)
                    return StatusCode(418);

                var token = await userManager.GeneratePasswordResetTokenAsync(user);
                await userManager.ResetPasswordAsync(user, token, model.NewPassword);

                return RedirectToAction("Index", "Home");

            }
            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "Admin, Trener")]
        public IActionResult DeletedUsers()
        {
            var users = _context.DeletedUser.ToList();

            return View(users);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(model.Email);
                if(user != null && await userManager.IsEmailConfirmedAsync(user))
                {
                    var token = await userManager.GeneratePasswordResetTokenAsync(user);
                    var pwResetLink = Url.Action("ResetPassword", "Account", new { email = model.Email, token = token }, Request.Scheme);

                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Resetovanje šifre", "befitapp@outlook.com"));
                    message.To.Add(new MailboxAddress(model.Email, model.Email));
                    message.Subject = "Resetovanje šifre";
                    var bodyBuilder = new BodyBuilder();
                    bodyBuilder.HtmlBody = "<div style='text-align:center; display:flex; flex-direction:column;'><h1 style='text-align:center; font-weight:400;'> Resetujte šifru </h1><p style='text-align:center;'> Klikom na sljedeći link, dobijate mogućnost resetovanja vaše šifre.</p><a class='buy-product' href = " + pwResetLink + "> Želim da resetujem šifru</a></div>";

                    message.Body = bodyBuilder.ToMessageBody();

                    using (var client = new SmtpClient())
                    {
                        client.Connect("smtp-mail.outlook.com", 587, false);
                        client.Authenticate("befitapp@outlook.com", "Befit!123");
                        client.Send(message);
                        client.Disconnect(true);

                    }

                    return View("ForgotPasswordConfirmation");
                }
                return View("ForgotPasswordConfirmation");
            }
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPassword(string email, string token)
        {
            if(token == null || email == null)
            {
                return StatusCode(418);
            }
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(model.Email);
                if(user != null)
                {
                    var result = await userManager.ResetPasswordAsync(user, model.Token, model.Password);
                    if (result.Succeeded)
                    {
                        if(await userManager.IsLockedOutAsync(user))
                        {
                            await userManager.SetLockoutEndDateAsync(user, DateTime.Now);
                        }

                        return View("ResetPasswordConfirmed");
                    }
                }
                return View("ResetPasswordConfirmed");
            }

            return View(model);
        }

        public IActionResult PrintUsers()
        {
            var dt = new DataTable();
            dt = usersService.GetUsersInfo();

            string mimeType = "";
            int extension = 1;
            var path = $"{hostingEnvironment.WebRootPath}\\Reports\\rptUserInfo.rdlc";

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("prm1", "RDLC Report");
            parameters.Add("prm2",DateTime.Now.ToString("dd.MM.yyyy"));
            parameters.Add("prm3", "Izvjestaj o clanovima");
            LocalReport localReport = new LocalReport(path);
            localReport.AddDataSource("dsUserInfo", dt);

            var res = localReport.Execute(RenderType.Pdf, extension, parameters, mimeType);

            return File(res.MainStream,"application/pdf");
        }


    }
}