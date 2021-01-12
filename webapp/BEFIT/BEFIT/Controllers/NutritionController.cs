using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BEFIT.Data;
using BEFIT.Models;
using BEFIT.ViewModels.Nutrition;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BEFIT.Controllers
{
    public class NutritionController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly IHostingEnvironment hostingEnvironment;
        private BEFITContext _context;
        public NutritionController(UserManager<User> userManager, BEFITContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            this.userManager = userManager;
            this.hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> List()
        {
            var logged = await userManager.GetUserAsync(User);
            var loggedRole = await userManager.IsInRoleAsync(logged, "Admin");
            var nutritionsPlans = _context.Nutrition.Include(c => c.User).Include(c => c.Author).ToList();
            var nutritionPlansFiltered = nutritionsPlans.FindAll(c => c.AuthorID == logged.Id || c.UserID == logged.Id);
            
            return View(loggedRole ? nutritionsPlans : nutritionPlansFiltered);
        }
  
        [HttpGet]
        [Authorize(Roles = "Admin, Trener")]
        public IActionResult Create(string id, int nutritionId, bool edit)
        {
            var user = _context.Users.SingleOrDefault(c => c.Id == id);
            var n = _context.Nutrition.SingleOrDefault(c => c.NutritionID == nutritionId);

            if (user == null)
                return StatusCode(418);
           
            var model = new CreateNutritionViewModel
            {
                Name = user.Firstname + " " + user.Lastname,
                Edit = edit
            };

            if (n != null && edit)
            {
                model.NutritionID = n.NutritionID;
                model.NutritionText = n.Description;
                model.Edit = edit;
            }
            return View(model);
        }
 
        [HttpPost]
        [Authorize(Roles = "Admin, Trener")]
        public async Task<IActionResult> Create(CreateNutritionViewModel model, string id)
        {

            var logged = await userManager.GetUserAsync(User);
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if(model.File != null)
                {
                    string uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "files");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.File.FileName;
                    string filePath = Path.Combine(uploadFolder, uniqueFileName);
                    model.File.CopyTo(new FileStream(filePath, FileMode.Create));

                }

                var nutrition = new Nutrition
                {
                    UserID = id,
                    Description = model.NutritionText,
                    Date = DateTime.Now,
                    AuthorID = logged.Id,
                    FilePath = uniqueFileName
                };

                if (model.Edit)
                {
                    var nutritionTemp = _context.Nutrition.Include(c => c.User).Include(c => c.Author).SingleOrDefault(c => c.NutritionID == model.NutritionID);
                    nutritionTemp.Description = model.NutritionText;
                    nutritionTemp.Date = DateTime.Now;
                    nutritionTemp.AuthorID = logged.Id;
                    nutritionTemp.FilePath = uniqueFileName;
                    _context.SaveChanges();
                    return RedirectToAction("List", "Nutrition");
                }
                _context.Nutrition.Add(nutrition);
                _context.SaveChanges();
                return RedirectToAction("List", "Nutrition");
            }
            var user = _context.Users.SingleOrDefault(c => c.Id == id);
            if (user == null)
                return StatusCode(418);
            model.Name = user.Firstname + " " + user.Lastname;

            return View(model);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Display(int id)
        {
            var n = _context.Nutrition.Include(c => c.Author).SingleOrDefault(c => c.NutritionID == id);
            if (n == null)
                return StatusCode(418);

            return View(n);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Display(int id, string submitButton)
        {

            if (submitButton.Equals("Obrisi"))
            {
                var nutrition = _context.Nutrition.SingleOrDefault(c => c.NutritionID == id);
                if (nutrition == null)
                    return StatusCode(418);

                //string uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "files");
                //string filePath = Path.Combine(uploadFolder, nutrition.FilePath);


                _context.Nutrition.Remove(nutrition);
                _context.SaveChanges();
                return RedirectToAction("List", "Nutrition");
            }
            else if (submitButton.Equals("Uredi"))
            {
                var n = _context.Nutrition.Include(c => c.User).Include(c => c.Author).SingleOrDefault(c => c.NutritionID == id);
                var userId = n.UserID;
                var logged = await userManager.GetUserAsync(User);
                var model = new CreateNutritionViewModel
                {
                    NutritionID = id,
                    UserID = userId,
                    Name = n.User.Firstname + " " + n.User.Lastname,
                    NutritionText = n.Description,
                    AuthorID = logged.Id,
                    
                };

                //return View("Create", model);
                return RedirectToAction("Create", new { id = userId, nutritionId = id, edit = true });
            }
   
            return View();
        }
        [HttpGet]
        public ActionResult DownloadFile(int id)
        {
            var nutrition = _context.Nutrition.SingleOrDefault(c => c.NutritionID == id);
            if (nutrition == null)
                return StatusCode(418);

            if (nutrition.FilePath != null)
            {
                string uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "files");
                string filePath = Path.Combine(uploadFolder, nutrition.FilePath);

                return PhysicalFile(filePath, "Application/msword", nutrition.FilePath);
            }
            return View("Display");
        }
    }
}