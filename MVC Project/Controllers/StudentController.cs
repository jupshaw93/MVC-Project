using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Project.Models;
using MVC_Project.ViewModels;


namespace MVC_Project.Controllers
{
    public class StudentController : Controller
    {
        private ApplicationDbContext _context;

        public StudentController()
        {
            _context = new ApplicationDbContext();
        }


        // GET: Student/List
        [Route("Student/List")]
        public ActionResult List()
        {
            var students = _context.students;

            return View(students);

        }
        public ActionResult Create()
        {
            var courses = _context.courses.ToList();
            var viewModel = new NewStudentViewModel
            {
                Courses = courses
            };


            return View(viewModel);
        }

        public ActionResult Edit()
        {
           

            return View();
        }
        public ActionResult Delete()
        {
           

            return View();
        }
        public ActionResult Update()
        {
            

            return View();
        }

          

    }



}

        
    