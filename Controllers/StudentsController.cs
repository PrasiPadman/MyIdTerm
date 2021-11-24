using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExpITMidTerm.Models;
using ExpITMidTerm.ViewModels;

namespace ExpITMidTerm.Controllers
{
    public class StudentsController : Controller
    {
        private ExpITMidTermcontext db = new ExpITMidTermcontext();
        // GET: Students
        public ActionResult Index()
        {
            var students = db.Students.ToList();
                      
            return View(students);
        }
       //public Actionresult new()
       // {
            
       //    var coursestatus = 

       //    return view(coursestatus);
       // }

    // GET: Students/Details/5
    public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }
        [HttpGet]
        public ActionResult Create()
        {
            var viewmodel = new StudentViewModel()
           
            {
                Student = new Student(),
                CourseList =db.Courses.ToList(),               
               
            };
            return View("Create",viewmodel);
        }
        [HttpPost]
        public ActionResult Create(Student student)
        { // Update the new students to the database
            db.Students.Add(student);
            db.SaveChanges();
            
            return RedirectToAction("Index");
        }
        [HttpGet]

        [HttpPost]
        //public ActionResult Create(CourseStatusModel courseStatus)
        //{
        //    CourseStatusModel model = new CourseStatusModel();

        //    model.CourseStatusList.Add(new SelectListItem { Text = "In Progress", Value = "1" });
        //    model.CourseStatusList.Add(new SelectListItem { Text = "Completed", Value = "2" });

        //    return View("Create");
        //}
       
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View("Edit",student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]


        public ActionResult Save( Student student)
        {
            var viewmodel = new StudentViewModel()
            {
                Student = new Student(),
                CourseList = db.Courses.ToList()
            };
            
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Create",viewmodel);
        }

        // GET: Students/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}