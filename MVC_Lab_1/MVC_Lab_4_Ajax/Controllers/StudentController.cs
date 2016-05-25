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
            if (Session["student"] == null)
                return View();
            return View((Student)Session["student"]);
        }

        public ActionResult PersonInitializer()
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
            Session["student"] = student;
            Session["grades"] = student.Grades;
            return RedirectToAction("Index");
        }

        public PartialViewResult _ShowGrades(/*List<Grade> grades*/)
        {
            var grades = (List<Grade>)Session["grades"];
            return PartialView(viewName: "_ShowGrades", model: grades);
        }
        
        public PartialViewResult _Create()
        {
            return PartialView();
        }
        public PartialViewResult _AddGrade(Grade grade)
        {
            if (ModelState.IsValid)
            {
                List<Grade> grades = (List<Grade>)Session["grades"];
                grades.Add(grade);
                Session["grades"] = grades;
                return PartialView(viewName: "_ShowGrades", model: grades);
            }

            return PartialView(viewName: "_Create", model: grade);
        }
    }
}