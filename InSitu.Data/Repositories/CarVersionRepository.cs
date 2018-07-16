namespace InSitu.Data.Repositories
{
    using System;
    using System.Linq;

    using InSitu.Data.Contexts;
    using InSitu.Data.Models.CarInformation;

    public class CarVersionRepository : BaseRepository<CarVersion>
    {
        public CarVersionRepository(InSituContext context)
            : base(context)
        {
        }

        public override IQueryable<CarVersion> All()
        {
            return this.Context.CarVersions;
        }

        protected override CarVersion MapNewValuesToOld(CarVersion oldEntity, CarVersion newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
