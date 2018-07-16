using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InSitu.Data.Repositories
{
    using InSitu.Data.Contexts;
    using InSitu.Data.Models.CarInformation;
    public class FuelTypeRepository : BaseRepository<FuelType>
    {
        public FuelTypeRepository(InSituContext context)
            : base(context)
        {
        }

        public override IQueryable<FuelType> All()
        {
            return this.Context.FuelTypes;
        }

        protected override FuelType MapNewValuesToOld(FuelType oldEntity, FuelType newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
