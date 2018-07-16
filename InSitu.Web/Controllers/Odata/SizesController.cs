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

    public class SizesController : OdataBaseController<Size, int>
    {
        public SizesController(BaseRepository<Size> repository)
            : base(repository)
        {
        }

        public override IQueryable<Size> CreateSingle(int key)
        {
            throw new NotImplementedException();
        }

        public override bool EntityExists(int key)
        {
            throw new NotImplementedException();
        }

        public override bool EntityExists(Size entity)
        {
            throw new NotImplementedException();
        }
    }
}
