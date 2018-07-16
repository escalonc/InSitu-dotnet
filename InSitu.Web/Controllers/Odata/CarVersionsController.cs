using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InSitu.Web.Controllers.Odata
{
    using InSitu.Data.Repositories;

    public class CarVersionsController : OdataBaseController<Version, int>
    {
        public CarVersionsController(BaseRepository<Version> repository)
            : base(repository)
        {
        }

        public override IQueryable<Version> CreateSingle(int key)
        {
            throw new NotImplementedException();
        }

        public override bool EntityExists(int key)
        {
            throw new NotImplementedException();
        }

        public override bool EntityExists(Version entity)
        {
            throw new NotImplementedException();
        }
    }
}
