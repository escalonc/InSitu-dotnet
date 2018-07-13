using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InSitu.Data.Repositories
{
    using InSitu.Data.Contexts;
    using InSitu.Data.Models.CarInformation;
    public class BrandRepository : BaseRepository<Brand>
    {
        public BrandRepository(InSituContext context)
            : base(context)
        {
        }

        public override IQueryable<Brand> All()
        {
            return this.Context.Brands;
        }

        protected override Brand MapNewValuesToOld(Brand oldEntity, Brand newEntity)
        {
            return oldEntity;
        }
    }
}
