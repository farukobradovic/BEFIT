using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BEFIT.Data;
using BEFIT.Models;
using BEFIT.ViewModels.ProgramArticle;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace BEFIT.Controllers
{
    public class ProgramArticleController : Controller
    {
        private readonly BEFITContext db;
        private readonly IHostingEnvironment hostingEnvironment;

        public ProgramArticleController(BEFITContext db, IHostingEnvironment hostingEnvironment)
        {
            this.db = db;
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {

            var index = db.ProgramArticle.ToList();

            return View(index);
        }

        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateProgramArticleVM model)
        {
            if (!ModelState.IsValid)
                return View("Create", model);

            string unique = null;
            if(model.Photo!=null)
            {
                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                unique = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, unique);
                model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
            }

            var article = new ProgramArticle
            {
                Id = model.Id,
                ProgramName = model.Name,
                ProgramDescription = model.Description,
                PhotoPath = unique,
                CreatedDate=DateTime.Now.ToString("dd.MM.yyyy")
            };

            db.Add(article);
            db.SaveChanges();

            return RedirectToAction("Index", "ProgramArticle");
        }

        public IActionResult DisplayProgramArticle(int id)
        {
            var article = db.ProgramArticle.FirstOrDefault(x=>x.Id==id);

            var model = new DisplayProgramArticleVM
            {
                Id = id,
                Name = article.ProgramName,
                Description = article.ProgramDescription,
                Photo = article.PhotoPath,
                Date=article.CreatedDate
            };

            return View("DisplayProgramArticle",model);
        }
    }
}
