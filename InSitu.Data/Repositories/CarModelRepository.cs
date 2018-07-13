using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InSitu.Data.Repositories
{
    using InSitu.Data.Contexts;
    using InSitu.Data.Models.CarInformation;
    public class CarModelRepository : BaseRepository<CarModel>
    {
        public CarModelRepository(InSituContext context)
            : base(context)
        {
        }

        public override IQueryable<CarModel> All()
        {
            return this.Context.CarModels;
        }

        protected override CarModel MapNewValuesToOld(CarModel oldEntity, CarModel newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
