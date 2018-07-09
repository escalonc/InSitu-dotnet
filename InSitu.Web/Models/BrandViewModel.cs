// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BrandViewModel.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   Defines the BrandViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Web.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// The brand view model.
    /// </summary>
    public class BrandViewModel
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