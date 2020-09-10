using Ninject.Activation;
using SBC.DAL;
using SBC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SBC.Controllers
{
    public class LernenController : Controller
    {
        IRepository<LernenItem> repository;

        public LernenController(IRepository<LernenItem> repo)
        {
            repository = repo;
        }
        // GET: Lernen
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Courses1()
        {
            int i = 1;
            List<LernenItem> list = new List<LernenItem>();
            foreach (var item in repository.GetAll())
            {
                int b = item.idLernen;
                int a = item.coursesItemId;
                if (Convert.ToInt32(item.coursesItemId) == i)
                {
                    list.Add(item);
                }
            }

            return View(list);
        }


        public ActionResult Courses2()
        {
            int i = 2;
            List<LernenItem> list = new List<LernenItem>();
            foreach (var item in repository.GetAll())
            {
                int b = item.idLernen;
                int a = item.coursesItemId;
                if (Convert.ToInt32(item.coursesItemId) == i)
                {
                    list.Add(item);
                }
            }

            return View(list);

        }

    }
}