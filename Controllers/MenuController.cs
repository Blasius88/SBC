using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBC.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }

        public string Main()
        {
            return "<span>Главное меню</span>";
        }

        public string UserInfo()
        {
            return "<span>Меню пользователя</span>";
        }

        public string Side()
        {
            return "<span>боковая панель</span>";
        }

        public string Map()
        {
            return "<span>Карта сайта</span>";
        }
    }
}