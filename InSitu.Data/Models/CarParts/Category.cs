// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Category.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   The category.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Data.Models.CarParts
{
    using System.Collections.Generic;

    /// <summary>
    /// The category.
    /// </summary>
    public class Category
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
        /// Gets or sets the car parts.
        /// </summary>
        public ICollection<PartType> CarPartTypesarts { get; set; } = new HashSet<PartType>();

        /// <summary>
        /// Gets or sets the sub categories.
        /// </summary>
        public virtual ICollection<SubCategory> SubCategories { get; set; } = new HashSet<SubCategory>();
    }
}
