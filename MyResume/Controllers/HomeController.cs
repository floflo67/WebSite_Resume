using MyResume.Models;
using MyResume.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyResume.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your about page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public ActionResult Blog()
        //{
        //    ViewBag.Message = "Your blog page.";
        //    List<BlogPostModels> list = getStaticLists.getBlogPostList();

        //    return View(list);
        //}

        public ActionResult Job()
        {
            ViewBag.Message = "Your job page.";
            List<JobModels> list = getStaticLists.getJobList();

            return View(list);
        }

        public ActionResult Course()
        {
            ViewBag.Message = "Your course page.";
            List<CourseModels> list = getStaticLists.getCourseList();

            return View(list);
        }

        public ActionResult Project()
        {
            ViewBag.Message = "Your project page.";
            List<ProjectModels> list = getStaticLists.getProjectList();

            return View(list);
        }
    }
}
