using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InSitu.Data.Repositories
{
    using InSitu.Data.Contexts;
    using InSitu.Data.Models.Person;
    public class CustomerRepository : BaseRepository<Customer>
    {
        public CustomerRepository(InSituContext context)
            : base(context)
        {
        }

        public override IQueryable<Customer> All()
        {
            return this.Context.Customers;
        }

        protected override Customer MapNewValuesToOld(Customer oldEntity, Customer newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
