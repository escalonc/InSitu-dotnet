// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CarPart.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   The car part.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Data.Models.Parts
{
    /// <summary>
    /// The car part.
    /// </summary>
    public class Part
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
        /// Gets or sets the car part type.
        /// </summary>
        public virtual PartType PartType { get; set; }
    }
}
