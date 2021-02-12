using StudentAPPWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPPWEB.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Student> Index { get; set; }
    }
}
