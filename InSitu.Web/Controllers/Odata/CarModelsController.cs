using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InSitu.Web.Controllers.Odata
{
    using InSitu.Data.Models.CarInformation;
    using InSitu.Data.Repositories;

    public class CarModelsController : OdataBaseController<CarModel, int>
    {
        public CarModelsController(BaseRepository<CarModel> repository)
            : base(repository)
        {
        }

        public override IQueryable<CarModel> CreateSingle(int key)
        {
            throw new NotImplementedException();
        }

        public override bool EntityExists(int key)
        {
            throw new NotImplementedException();
        }

        public override bool EntityExists(CarModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
