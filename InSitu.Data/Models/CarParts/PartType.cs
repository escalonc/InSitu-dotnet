// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CarPartType.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   Defines the CarPartType type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Data.Models.CarParts
{
    using System.Collections.Generic;

    /// <summary>
    /// The car part type.
    /// </summary>
    public class PartType
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
        public virtual ICollection<Part> CarParts { get; set; } = new HashSet<Part>();
    }
}
