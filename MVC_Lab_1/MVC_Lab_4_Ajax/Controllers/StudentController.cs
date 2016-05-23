using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Lab_4_Ajax.Models;

namespace MVC_Lab_4_Ajax.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Student student = new Student()
            {
                StudentID = 1,
                Name = "Bill",
                LastName = "Svensson",
                Personnumber = "123456-1234",
                Address = "Stenbergagatan",
                Grades = new List<Grade>()
                {
                    new Grade() {ID = 1, CourseName = "Math", GradeValue = "VG"},
                    new Grade() {ID = 2, CourseName = "History", GradeValue = "G"},
                    new Grade() {ID = 3, CourseName = "Art", GradeValue = "MVG"}
                }
            };
            return View(student);
        }

        public PartialViewResult _ShowGrades(List<Grade> grades)
        {
            return PartialView(viewName: "_ShowGrades", model: grades);
        }
    }
}