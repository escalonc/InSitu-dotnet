using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InSitu.Web.Controllers.Odata
{
    using InSitu.Data.Models.Person;
    using InSitu.Data.Repositories;

    public class CustomersController : OdataBaseController<Customer, int>
    {
        public CustomersController(BaseRepository<Customer> repository)
            : base(repository)
        {
        }

        public override IQueryable<Customer> CreateSingle(int key)
        {
            throw new NotImplementedException();
        }

        public override bool EntityExists(int key)
        {
            throw new NotImplementedException();
        }

        public override bool EntityExists(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
