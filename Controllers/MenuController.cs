﻿using SBC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SBC.DAL;

namespace SBC.Controllers
{
    public class MenuController : Controller
    {
        public PartialViewResult Main(string a = "Index", string c = "Home")
        {
            var mi = items.FirstOrDefault(m => m.Controller == c);
            if (mi != null)
                mi.Active = "active";
            return PartialView(items);
        }

        public PartialViewResult UserInfo()
        {
            return PartialView(items);
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
        };

    }
}