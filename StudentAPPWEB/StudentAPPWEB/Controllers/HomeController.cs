using Microsoft.AspNetCore.Mvc;
using StudentAPPWEB.Models;
using StudentAPPWEB.ViewModels;
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
            HomeIndexViewModel viewModel = new HomeIndexViewModel()
            {
                Index = _studentRepository.GetAll()
            };
            return View(viewModel) ;
        }
        public ViewResult Details()
        {


            HomeDetailsViewModel viewModel = new HomeDetailsViewModel()
            {
                Student = _studentRepository.Get(3),
                Title = "Title Student"
            };
            return View(viewModel);
        }
        public string Student()
        {
            return _studentRepository.Get(3)?.FirstName;
        }
        public ActionResult UniverStudent()
        {
            var Student = _studentRepository.getUniverStudent("UzMU");
            return View(Student);
        }
        public string My()
        {
            return "MY dan salom";
        }
    }
}
