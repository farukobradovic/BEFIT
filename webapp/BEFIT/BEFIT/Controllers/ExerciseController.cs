using BEFIT.Data;
using BEFIT.Models;
using BEFIT.ViewModels.Exercise;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.Controllers
{
    public class ExerciseController:Controller
    {
        private readonly BEFITContext ct;
        private readonly IHostingEnvironment hostingEnvironment;

        public ExerciseController(BEFITContext ct,IHostingEnvironment hostingEnvironment)
        {
            this.ct = ct;
            this.hostingEnvironment = hostingEnvironment;
        }


        public IActionResult ListaVjezbi()
        {
            //List<Exercise> listaVjezbi = ct.Exercise.ToList();
            //return View(listaVjezbi);

            var lista = new ListaVjezbiVM
            {
                Category = ct.Category.Select(
                     x => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                     {
                         Value = x.CategoryID.ToString(),
                         Text = x.CategoryName
                     }
                    ).ToList()
            };

            return View(lista);

        }


        public IActionResult _ListaVjezbi(int id)
        {
            var category = ct.Category.Find(id);

            var index = new DisplayVjezbePartialVM
            {
                CategoryId = category.CategoryID,
                rows = ct.Exercise.Where(i => i.CategoryID == id)
                     .Select(x => new DisplayVjezbePartialVM.Rows
                     {
                         ExerciseId=x.ExerciseID,
                         ExerciseName=x.ExerciseName,
                         Description=x.Description,
                         PhotoPath=x.PhotoPath,
                         CategoryName=x.Category.CategoryName
                     }).ToList()
            };


            return PartialView(index);
        }

        public IActionResult AddExercise()
        {
            return View("AddExercise", listaKategorija(new KreirajVjezbuVM()));
        }

        [HttpPost]
        public IActionResult AddExercise(KreirajVjezbuVM vm)
        {

            if (!ModelState.IsValid)
                return View("AddExercise",vm);


            string uFileName = null;
            if(vm.Photo!=null)
            {
                string uploadFolder=Path.Combine(hostingEnvironment.WebRootPath, "images");
                uFileName = Guid.NewGuid().ToString() + "_" + vm.Photo.FileName;
                string filePath=Path.Combine(uploadFolder, uFileName);
                vm.Photo.CopyTo(new FileStream(filePath,FileMode.Create));
            }

            var vjezba = new Exercise()
            {
                ExerciseID = vm.ID,
                ExerciseName = vm.ExerciseName,
                Description = vm.Description,
                CategoryID = vm.CategoryID,
                PhotoPath = uFileName
            };

            ct.Exercise.Add(vjezba);
            ct.SaveChanges();



            return RedirectToAction("ListaVjezbi","Exercise");
        }

        public KreirajVjezbuVM listaKategorija(KreirajVjezbuVM vm)
        {
            vm.Category = ct.Category.Select(x => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
            {
                Text=x.CategoryName,
                Value=x.CategoryID.ToString()
            }).ToList();

            return vm;
        }

        public IActionResult DisplayExercise(int id)
        {
            var exerciseID = ct.Exercise.Include(x => x.Category).FirstOrDefault(x => x.ExerciseID == id);

            var obj = new DisplayViewModel
            {
                ID=exerciseID.ExerciseID,
                ExerciseName=exerciseID.ExerciseName,
                ExerciseDescription=exerciseID.Description,
                CategoryName=exerciseID.Category.CategoryName,
                Photo=exerciseID.PhotoPath

            };

           

            return View("DisplayExercise",obj);

        }

        public IActionResult DeleteExercise(int id)
        {
            var obrisi = ct.Exercise.Where(x => x.ExerciseID == id).FirstOrDefault();

            if (obrisi == null)
                return StatusCode(418);

            ct.Exercise.Remove(obrisi);
            ct.SaveChanges();

            return RedirectToAction("ListaVjezbi", "Exercise");
        } 

        public IActionResult EditExercise(int id)
        {
            var vjezba = ct.Exercise.Include(x => x.Category).FirstOrDefault(x => x.ExerciseID == id);

            return View("EditExercise",listaKategorija(new KreirajVjezbuVM()));

        }
        [HttpPost]
        public IActionResult EditExercise(KreirajVjezbuVM vm, int id)
        {
            var vjezba = ct.Exercise.Include(x => x.Category).FirstOrDefault(x => x.ExerciseID == id);

            if (vjezba == null)
                return StatusCode(418);

            ////var model = new DisplayViewModel
            ////{
            ////    ID=vjezba.ExerciseID,
            ////    ExerciseName=vjezba.ExerciseName,
            ////    Difficulty=vjezba.Difficulty,
            ////    ExerciseDescription=vjezba.Description,
            ////    CategoryName=vjezba.Category.CategoryName
            ////};

            vjezba.ExerciseName = vm.ExerciseName;
            vjezba.Description = vm.Description;
            vjezba.Difficulty = vm.Difficulty;

            ct.SaveChanges();

            return RedirectToAction("ListaVjezbi","Exercise");
            }
        }
    }
