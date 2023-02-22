using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission06_norty144.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_norty144.Controllers
{
    public class HomeController : Controller
    {

        private MovieDataContext MFContext { get; set; }
        
        //constructor
        public HomeController(MovieDataContext someName)
        {
            MFContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }








        public IActionResult Podcasts()
        {
            return View();
        }







        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Categories = MFContext.Categories.ToList();

            return View("MovieForm", new MovieResponse());
        }






        [HttpPost]
        public IActionResult MovieForm(MovieResponse mr)
        {
            if (ModelState.IsValid)
            {
                MFContext.Add(mr);
                MFContext.SaveChanges();

                return View("Confirmation", mr);
            }
            else //invalid
            {
                ViewBag.Categories = MFContext.Categories.ToList();

                return View(mr);
            }

            
        }






        [HttpGet]
        public IActionResult MovieList()
        {
            var submissions = MFContext.responses
               .Include(x => x.Category)
               .OrderBy(x => x.Category)
               .ToList();

            return View(submissions);
        }





        [HttpGet]
        public IActionResult Edit ( int id )
        {
            ViewBag.Categories = MFContext.Categories.ToList();

            var form = MFContext.responses.Single(x => x.MovieId == id);

            return View("MovieForm", form);
        }





        [HttpPost]
        public IActionResult Edit (MovieResponse er)
        {
            MFContext.Update(er);
            MFContext.SaveChanges();

            return RedirectToAction("MovieList");
        }




        [HttpGet]
        public IActionResult Delete ( int id )
        {
            var form = MFContext.responses.Single(x => x.MovieId == id);

            return View(form);
        }




        [HttpPost]
        public IActionResult Delete(MovieResponse dr)
        {
            MFContext.responses.Remove(dr);
            MFContext.SaveChanges();

            return RedirectToAction("MovieList");
        }


    }
}
