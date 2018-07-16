using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InSitu.Data.Repositories
{
    using InSitu.Data.Contexts;
    using InSitu.Data.Models.CarInformation;
    public class UseTypeRepository : BaseRepository<UseType>
    {
        public UseTypeRepository(InSituContext context)
            : base(context)
        {
        }

        public override IQueryable<UseType> All()
        {
            return this.Context.UseTypes;
        }

        protected override UseType MapNewValuesToOld(UseType oldEntity, UseType newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
