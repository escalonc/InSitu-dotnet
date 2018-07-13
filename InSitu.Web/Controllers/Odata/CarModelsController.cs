using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using InSitu.Data.Contexts;
using InSitu.Data.Models.CarInformation;

namespace InSitu.Web.Controllers.Odata
{
    using InSitu.Data.Repositories;

    public class CarModelsController : ApiController
    {
        private readonly BaseRepository<CarModel> carModelRepository;

        public CarModelsController(BaseRepository<CarModel> carModelRepository)
        {
            this.carModelRepository = carModelRepository;
        }

        public string Get()
        {
            return "Hello";
        }
    }
}