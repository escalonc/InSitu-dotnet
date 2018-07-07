// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Category.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   The category.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Data.Models.Parts
{
    using System.Collections.Generic;

    /// <summary>
    /// The category.
    /// </summary>
    public class PartTypeCategory
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
        /// Gets or sets the part type sub category.
        /// </summary>
        public virtual PartTypeSubCategory PartTypeSubCategory { get; set; }

        /// <summary>
        /// Gets or sets the car parts.
        /// </summary>
        public virtual ICollection<PartType> PartTypes { get; set; } = new HashSet<PartType>();
    }
}
