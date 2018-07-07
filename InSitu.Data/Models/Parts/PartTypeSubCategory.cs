// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SubCategory.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   The sub category.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Data.Models.Parts
{
    using System.Collections.Generic;

    /// <summary>
    /// The sub category.
    /// </summary>
    public class PartTypeSubCategory
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
        /// Gets or sets the part type category.
        /// </summary>
        public virtual PartTypeCategory PartTypeCategory { get; set; }

        /// <summary>
        /// Gets or sets the car part types.
        /// </summary>
        public virtual ICollection<PartType> CarPartTypes { get; set; } = new HashSet<PartType>();
    }
}
