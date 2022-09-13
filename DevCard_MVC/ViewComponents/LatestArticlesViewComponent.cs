using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_MVC.Models;

namespace DevCard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Articles = new List<Article>
            {
                new Article(1,"آموزش Asp.net core mvc","کاملترین پکیج آموزش Asp.net core mvc به زبان فارسی","blog-post-thumb-card-1.jpg"),
                new Article(2,"آموزش Git & Github","کاملترین پکیج آموزش Git & Github به زبان فارسی","blog-post-thumb-card-2.jpg"),
                new Article(3,"آموزش Onion Architecture","کاملترین پکیج آموزش Onion Architecture به زبان فارسی","blog-post-thumb-card-3.jpg"),
                new Article(4,"آموزش طراحی سایت","کاملترین پکیج آموزش طراحی سایت به زبان فارسی","blog-post-thumb-card-4.jpg"),
            };
            return View("_LatestArticles",Articles);
        }
    }
}
