using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BEFIT.Data;
using BEFIT.Models;
using BEFIT.ViewModels.Training;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BEFIT.Controllers
{
    public class TrainingController : Controller
    {
        private readonly UserManager<User> userManager;
        private BEFITContext _context;

        public TrainingController(BEFITContext context, UserManager<User> userManager)
        {
            _context = context;
            this.userManager = userManager;
        }

        [HttpGet]
        [Authorize(Roles = "Admin, Trener")]
        public IActionResult Create(string id)
        {
            var user = _context.Users.SingleOrDefault(c => c.Id == id);
            var model = new CreateTrainingViewModel
            {
                TrainingCategories = _context.TrainingType.ToList(),
                NameLastname = user.Firstname + " " + user.Lastname,
                TrainingFrom = DateTime.Now,
                TrainingTill = DateTime.Now
            };

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Admin, Trener")]
        public IActionResult Create(CreateTrainingViewModel model, string id)
        {
            if (ModelState.IsValid)
            {
                var c = _context.TrainingType.SingleOrDefault(ct => ct.TrainingTypeName == model.TrainingCategory);
                if (c == null)
                    return StatusCode(418);

                if(model.TrainingFrom == model.TrainingTill)
                {
                    ModelState.AddModelError(string.Empty, "Početak i kraj treninga ne mogu biti isti");
                    var categoriesT = _context.TrainingType.ToList();
                    var user = _context.Users.SingleOrDefault(d => d.Id == id);
                    model.TrainingCategories = categoriesT;
                    model.NameLastname = user.Firstname + " " + user.Lastname;
                    return View(model);
                }
                var loggedID = userManager.GetUserId(User);
                var userTrained = _context.Users.SingleOrDefault(z => z.Id == id);
                if (userTrained == null)
                    return StatusCode(418);
                var trainings = _context.Training.Include(z => z.Author).Include(z => z.User).ToList();
                var from = model.TrainingFrom.Date;
                var till = model.TrainingTill.Date;

                var counter = 0;
                var counter2 = 0;
                //Provjera da li trening koji smo proslijedili moze da se zakaze, tj da li neko od ucesnika vec ima trening na taj termin
                for (int i = 0; i < trainings.Count(); i++)
                {
                    if (trainings[i].TrainingFrom.Date == from)
                    {
                        if ((model.TrainingFrom <= trainings[i].TrainingFrom && model.TrainingTill <= trainings[i].TrainingFrom) ||
                            (model.TrainingFrom >= trainings[i].TrainingTill && model.TrainingTill >= trainings[i].TrainingTill))
                        {
                            counter++;
                        }
                        else
                        {
                            if (trainings[i].AuthorID == loggedID || trainings[i].UserID == userTrained.Id)
                            {
                                counter2++;
                            }
                            else counter++;
                        }
                    }
                    else counter++;
                }

                bool nextMove = false;
                if (counter == trainings.Count())
                    nextMove = true;

                if (!nextMove)
                {
                    ModelState.AddModelError(string.Empty, "Jedan/na ili oba učesnika treninga već ima/ju zakazan termin na taj datum");
                    var categoriesT = _context.TrainingType.ToList();
                    var user = _context.Users.SingleOrDefault(d => d.Id == id);
                    model.TrainingCategories = categoriesT;
                    model.NameLastname = user.Firstname + " " + user.Lastname;
                    return View(model);
                }


                var training = new Training
                {
                    TrainingFrom = model.TrainingFrom,
                    TrainingTill = model.TrainingTill,
                    TrainingTypeID = c.TrainingTypeID,
                    AuthorID = loggedID,
                    UserID = userTrained.Id
                };

                _context.Training.Add(training);
                _context.SaveChanges();

                return RedirectToAction("Display", "Training");
            }
            var categories = _context.TrainingType.ToList();
            model.TrainingCategories = categories;
            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult AddCategory(AddCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var category = new TrainingType
                {
                    TrainingTypeName = model.Name,
                    Description = model.Description
                };

                _context.TrainingType.Add(category);
                _context.SaveChanges();
                return RedirectToAction("DisplayCategories", "Training");

            }


            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult DisplayCategories()
        {
            var categories = _context.TrainingType.ToList();
            return View(categories);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult DisplayCategories(int id)
        {
            var category = _context.TrainingType.SingleOrDefault(c => c.TrainingTypeID == id);
            if (category == null)
                return StatusCode(418);
            _context.TrainingType.Remove(category);
            _context.SaveChanges();

            return RedirectToAction("DisplayCategories", "Training");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Display()
        {
            var logged = await userManager.GetUserAsync(HttpContext.User);
            var loggedRole = await userManager.IsInRoleAsync(logged, "Admin");

            var trainings = _context.Training.Include(c => c.Author).Include(c => c.User).Include(c => c.TrainingType).ToList();
            var trainingsFiltered = trainings.FindAll(c => c.UserID == logged.Id || c.AuthorID == logged.Id);

            var data = loggedRole ? trainings : trainingsFiltered;

            return View(data);
            //return RedirectToAction("Display");
        }
        //Brisanje treninga sa svim njegovim informacijama iz druge tabele
        [HttpPost]
        [Authorize]
        public IActionResult Display(int id)
        {
            var training = _context.Training.FirstOrDefault(c => c.TrainingID == id);
            if (training == null)
                return StatusCode(418);
            _context.Training.Remove(training);
            _context.SaveChanges();

            return RedirectToAction("Display", "Training");            
           
        }
    }
}