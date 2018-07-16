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

    public class FuelTypesController : OdataBaseController<FuelType, int>
    {
        public FuelTypesController(BaseRepository<FuelType> repository)
            : base(repository)
        {
        }

        public override IQueryable<FuelType> CreateSingle(int key)
        {
            throw new NotImplementedException();
        }

        public override bool EntityExists(int key)
        {
            throw new NotImplementedException();
        }

        public override bool EntityExists(FuelType entity)
        {
            throw new NotImplementedException();
        }
    }
}
