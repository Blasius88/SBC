using SBC.DAL;
using SBC.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace SBC.Controllers
{
 [Authorize (Roles ="User, admin, theacher")]
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
                int b = Convert.ToInt32(item.idLernen);
                int a = Convert.ToInt32(item.coursesItemId);
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
                int b = Convert.ToInt32(item.idLernen);
                int a = Convert.ToInt32(item.coursesItemId);
                if (Convert.ToInt32(item.coursesItemId) == i)
                {
                    list.Add(item);
                }
            }

            return View(list);

        }

    }
}