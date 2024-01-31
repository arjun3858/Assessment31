using Assessment31.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assessment31.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        static List<Course> courses = new List<Course>()
        {
            new Course{CId=1,CName="DataScience",CFee=82000,Technology="AI",CStartData=new DateTime(day:21,month:12,year:2023),CEndData=new DateTime(day:21,month:12,year:2024) },
             new Course{CId=2,CName="FullStack",CFee=50000,Technology="Java ",CStartData=new DateTime(day:12,month:07,year:2023),CEndData=new DateTime(day:12,month:07,year:2024) },
              new Course{CId=3,CName="CyberSecurity",CFee=9000,Technology="Web",CStartData=new DateTime(day:24,month:11,year:2023),CEndData=new DateTime(day:01,month:01,year:2024) },
               new Course{CId=4,CName="Cloud Computing",CFee=85000,Technology="IOT",CStartData=new DateTime(day:08,month:02,year:2023),CEndData=new DateTime(day:11,month:09,year:2024) },
                new Course{CId=5,CName="Digital Marketing",CFee=50000,Technology="Advertising",CStartData=new DateTime(day:11,month:07,year:2023),CEndData=new DateTime(day:01,month:08,year:2024) },
        };
        public ActionResult Index()
        {
            return View(courses);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Course());
        }
        [HttpPost]
        public ActionResult Create( Course course)
        {
            if(ModelState.IsValid)
            {
                courses.Add(course);
                return RedirectToAction("Index");
            }
            return View(course);
            
        }
    }
}