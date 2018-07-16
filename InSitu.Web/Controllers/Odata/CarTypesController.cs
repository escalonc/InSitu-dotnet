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

    public class CarTypesController : OdataBaseController<CarType, int>
    {
        public CarTypesController(BaseRepository<CarType> repository)
            : base(repository)
        {
        }

        public override IQueryable<CarType> CreateSingle(int key)
        {
            throw new NotImplementedException();
        }

        public override bool EntityExists(int key)
        {
            throw new NotImplementedException();
        }

        public override bool EntityExists(CarType entity)
        {
            throw new NotImplementedException();
        }
    }
}
