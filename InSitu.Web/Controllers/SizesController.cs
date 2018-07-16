using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InSitu.Web.Controllers
{
    public class SizesController : Controller
    {
        // GET: Sizes
        public ActionResult Index()
        {
            return View();
        }

        // GET: Sizes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sizes/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            return View();
        }
    }
}
