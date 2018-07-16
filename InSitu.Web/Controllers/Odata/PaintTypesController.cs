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

    public class PaintTypesController : OdataBaseController<PaintType, int>
    {
        public PaintTypesController(BaseRepository<PaintType> repository)
            : base(repository)
        {
        }

        public override IQueryable<PaintType> CreateSingle(int key)
        {
            throw new NotImplementedException();
        }

        public override bool EntityExists(int key)
        {
            throw new NotImplementedException();
        }

        public override bool EntityExists(PaintType entity)
        {
            throw new NotImplementedException();
        }
    }
}
