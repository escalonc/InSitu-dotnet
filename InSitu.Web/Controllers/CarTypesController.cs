using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InSitu.Web.Controllers
{
    public class CarTypesController : Controller
    {
        // GET: CarTypes
        public ActionResult Index()
        {
            return View();
        }

        // GET: CarTypes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CarTypes/Create
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
