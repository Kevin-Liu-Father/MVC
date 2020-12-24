using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;

namespace MVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index(int pageIndex = 1 , int pageSize = 2)
        {
            //ViewBag.list = StudentManager.GetStudents();
            ViewBag.list = StudentManager.PageList(pageIndex,pageSize);
            ViewBag.index = pageIndex;
            ViewBag.count = StudentManager.GetCount(pageSize);
            return View();
        }

        public ActionResult Del(int id)
        {
           int result=  StudentManager.Del(id);
            return RedirectToAction("Index");
        }
        public ActionResult Add()
        {
            ViewBag.classes = ClassManager.GetClasses();
            return View();
        }

        public ActionResult AddStudent(students stu)
        {
            int result = StudentManager.Add(stu);
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id)
        {
            ViewBag.classes = ClassManager.GetClasses();
            ViewBag.student = StudentManager.ByIdGetStu(id);
            return View();
        }

        public ActionResult Edit(students stu)
        {
            int result = StudentManager.Edit(stu);
            return RedirectToAction("Index");
        }

        public ActionResult CF()
        {
            return View();
        }
        public void d()
        {
            string an = "你是煞笔";
        }

    }
}