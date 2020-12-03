using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Project.Models;

namespace MVC_Project.Controllers
{
    public class CourseController : Controller
    {
        private ApplicationDbContext _context;

        public CourseController()
        {
            _context = new ApplicationDbContext();
        }


        // GET: Course/List
        public ActionResult List()
        {
            Course courses = new Course() {};

            return View(courses);


        }

        public ActionResult Create()
        {
            

            return View();
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