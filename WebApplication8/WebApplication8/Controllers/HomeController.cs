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
        public ActionResult ProcessData(Post model)
        {
            using(var context = new Context())
            {
                if(model.Text == null && model.Nik == null)
                {
                    return Json(context.Posts.ToList(), JsonRequestBehavior.AllowGet);
                }
                else
                {
                    var post = new List<Post>
                    {
                        new Post
                        {
                            Text = model.Text,
                            Nik = model.Nik
                        }
                    };
                    context.Posts.AddRange(post);
                    context.SaveChanges();
                    return Json(context.Posts.ToList(), JsonRequestBehavior.AllowGet);
                }
            }

        }
    }
}