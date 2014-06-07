using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using CISTermProject634.Models;
using Models;


namespace CISTermProject634.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            

            var model = Storage.GetRecentArticles();

            return View(model);
        }
        
        public ActionResult About()
        {

            return View();
        }
        
        public ActionResult SubmitArticle()
        {
            return View(new NewArticleModel());
        }

        [HttpPost]
        public ActionResult SubmitArticle(NewArticleModel article)
        {
            if (ModelState.IsValid)
            {
                StoryLink articleEntity = new StoryLink()
                {
                    Title = article.title,
                    Url = article.Site,
                    DateAdded = DateTime.UtcNow
                };

                Storage.AddArticle(articleEntity);
                
                return RedirectToAction("Index");
            }

            return View(article);
        }
    }
}
