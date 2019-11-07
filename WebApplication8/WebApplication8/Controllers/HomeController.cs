using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication8.DataAccess;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProcessData(string nik, string text)
        {
            using(var context = new Context())
            {
                var post = new List<Post> 
                {
                    new Post
                    {
                        Text = text,
                        Nik = nik
                    }
                    
                };
                
                context.Posts.AddRange(post);
                context.SaveChanges();

                return Json(context.Posts.ToList(), JsonRequestBehavior.AllowGet);
            }

        }
    }
}