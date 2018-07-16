using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InSitu.Web.Controllers
{
    public class CarModelsController : Controller
    {
        // GET: CarModel
        public ActionResult Index()
        {
            return View();
        }

        // GET: CarModel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CarModel/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: CarModel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
    }
}
