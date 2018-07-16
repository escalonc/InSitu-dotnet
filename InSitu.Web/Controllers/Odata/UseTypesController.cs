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

    public class UseTypesController : OdataBaseController<UseType, int>
    {
        public UseTypesController(BaseRepository<UseType> repository)
            : base(repository)
        {
        }

        public override IQueryable<UseType> CreateSingle(int key)
        {
            throw new NotImplementedException();
        }

        public override bool EntityExists(int key)
        {
            throw new NotImplementedException();
        }

        public override bool EntityExists(UseType entity)
        {
            throw new NotImplementedException();
        }
    }
}
