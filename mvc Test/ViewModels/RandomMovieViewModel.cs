using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvc_Test.Models;

namespace mvc_Test.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Custumers { get; set; }
    }
}