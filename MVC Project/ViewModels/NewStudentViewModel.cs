using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Project.Models;

namespace MVC_Project.ViewModels
{
    public class NewStudentViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
        public Student student { get; set; }
    }
}