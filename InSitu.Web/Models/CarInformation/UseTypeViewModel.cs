using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InSitu.Web.Models.CarInformation
{
    public class UseTypeViewModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the cars.
        /// </summary>
        public virtual ICollection<CarViewModel> Cars { get; set; } = new HashSet<CarViewModel>();
    }
}