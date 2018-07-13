using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InSitu.Web.Controllers
{
    using InSitu.Data.Models.CarInformation;
    using InSitu.Data.Repositories;

    public class BrandsController : Controller
    {
        // GET: Brands
        public ActionResult Index()
        {
            return View();
        }
    }
}