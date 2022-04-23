using Microsoft.AspNetCore.Mvc;
using portfolio_project.Models;
using System.Collections.Generic;

namespace portfolio_project.ViewComponents
{
    public class LatesArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article {Id=1, Title="آموزش Asp.net core mvc",Description= "کاملترین پکیج آموزش asp.net core mvc به زبان فارسی",
                    Image="blog-post-thumb-card-1.jpg" },
                 new Article{Id=2, Title="آموزش Git & Github",Description= "کاملترین پکیج آموزش Git & Github به زبان فارسی",
                     Image="blog-post-thumb-card-2.jpg" },
                new Article{Id=3, Title="آموزش Onion Architecture", Description="کاملترین پکیج آموزش Onion Architecture به زبان فارسی",
                     Image="blog-post-thumb-card-3.jpg" },
                new Article{Id=4,Title= "آموزش طراحی سایت",Description= "کاملترین پکیج آموزش طراحی سایت به زبان فارسی",
                     Image="blog-post-thumb-card-4.jpg" }
            };

            //var articles = new List<Article>
            //{
            //    new Article(1, "آموزش Asp.net core mvc", "کاملترین پکیج آموزش asp.net core mvc به زبان فارسی",
            //        "blog-post-thumb-card-1.jpg"),
            //    new Article(2, "آموزش Git & Github", "کاملترین پکیج آموزش Git & Github به زبان فارسی",
            //        "blog-post-thumb-card-2.jpg"),
            //    new Article(3, "آموزش Onion Architecture", "کاملترین پکیج آموزش Onion Architecture به زبان فارسی",
            //        "blog-post-thumb-card-3.jpg"),
            //    new Article(4, "آموزش طراحی سایت", "کاملترین پکیج آموزش طراحی سایت به زبان فارسی",
            //        "blog-post-thumb-card-4.jpg"),
            //};

            return View("_LatesArticles", articles);
        }
    }
}
