using SBC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBC.Controllers
{
    public class MenuController : Controller
    {
        public PartialViewResult Main(string a = "Index", string c = "Home")
        {
            items.First(m => m.Controller == c).Active = "active";
            return PartialView(items);
        }

        public PartialViewResult UserInfo()
        {
            return PartialView();
        }

        public PartialViewResult Side()
        {
            return PartialView();
        }

        public PartialViewResult Map()
        {
            return PartialView(items);
        }

        List<MenuItem> items = new List<MenuItem>()
        {
            new MenuItem{Name ="Домой", Controller="Home", Action="Index", Active=string.Empty},
            new MenuItem{Name="Наши курсы", Controller="Courses", Action="Index", Active=string.Empty},
            new MenuItem{Name="Администрирование", Controller="Admin",Action="Index", Active=string.Empty},
        };
    }
}