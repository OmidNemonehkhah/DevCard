using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_MVC.Models;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Projects = new List<Project>
            {
                new Project(1,"تاکسی","درخواست آنلاین تاکسی برای سفرهای درون شهری","project-1.jpg","Atria"),
                new Project(2,"زود فود","درخواست آنلاین غذا برای سراسر کشور","project-2.jpg","ZoodFood"),
                new Project(3,"مدارس","سیستم مدیریت یکپارچه مدارس","project-3.jpg","MONOP"),
                new Project(4,"فضا پیما","برنامه مدیریت فضا پیماهای ناسا","project-4.jpg","NASA"),
            };
            return View("_Projects",Projects);
        }
    }
}
