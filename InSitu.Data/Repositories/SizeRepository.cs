using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InSitu.Data.Repositories
{
    using InSitu.Data.Contexts;
    using InSitu.Data.Models.CarInformation;
    public class SizeRepository : BaseRepository<Size>
    {
        public SizeRepository(InSituContext context)
            : base(context)
        {
        }

        public override IQueryable<Size> All()
        {
            return this.Context.Sizes;
        }

        protected override Size MapNewValuesToOld(Size oldEntity, Size newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
