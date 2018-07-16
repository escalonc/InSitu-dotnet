using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InSitu.Data.Repositories
{
    using InSitu.Data.Contexts;
    using InSitu.Data.Models.CarInformation;
    public class PaintTypeRepository : BaseRepository<PaintType>
    {
        public PaintTypeRepository(InSituContext context)
            : base(context)
        {
        }

        public override IQueryable<PaintType> All()
        {
            return this.Context.PaintTypes;
        }

        protected override PaintType MapNewValuesToOld(PaintType oldEntity, PaintType newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
