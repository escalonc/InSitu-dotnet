using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InSitu.Data.Repositories
{
    using InSitu.Data.Contexts;
    using InSitu.Data.Models.CarInformation;
    public class CarTypeRepository : BaseRepository<CarType>
    {
        public CarTypeRepository(InSituContext context)
            : base(context)
        {
        }

        public override IQueryable<CarType> All()
        {
            return this.Context.CarTypes;
        }

        protected override CarType MapNewValuesToOld(CarType oldEntity, CarType newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
