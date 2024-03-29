﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InSitu.Web.Controllers.Odata
{
    using InSitu.Data.Models.CarInformation;
    using InSitu.Data.Repositories;

    public class CarVersionsController : OdataBaseController<CarVersion, int>
    {
        public CarVersionsController(BaseRepository<CarVersion> repository)
            : base(repository)
        {
        }

        public override IQueryable<CarVersion> CreateSingle(int key)
        {
            throw new NotImplementedException();
        }

        public override bool EntityExists(int key)
        {
            throw new NotImplementedException();
        }

        public override bool EntityExists(CarVersion entity)
        {
            throw new NotImplementedException();
        }
    }
}
