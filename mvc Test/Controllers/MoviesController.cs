using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_Test.Models;
using mvc_Test.ViewModels;

namespace mvc_Test.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
           {
               new Customer {Name = "costumer 1" },
               new Customer {Name = "costumer 2" }
               
           };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Custumers = customers

            };
            return View(viewModel);
        }
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "//" + month+"hi my name is pooya");
            
        }

    } 
}