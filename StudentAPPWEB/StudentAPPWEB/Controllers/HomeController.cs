using Microsoft.AspNetCore.Mvc;
using StudentAPPWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPPWEB.Controllers
{
    public class HomeController:Controller
    {
        private readonly IStudentRepository _studentRepository;

        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public ViewResult Index()
        {
            return View() ;
        }
        public ViewResult Details()
        {
            var Student = _studentRepository.Get(3);
            ViewData["student"] = Student;
            ViewData["title"] = "Title Student";
            return View();
        }
        public string Student()
        {
            return _studentRepository.Get(3)?.FirstName;
        }
        public ViewResult UniverStudent()
        {
            var Student = _studentRepository.getUniverStudent("UzMU");
            ViewData["univerStudent"] = Student;
            return View();
        }
        public string My()
        {
            return "MY dan salom";
        }
    }
}
