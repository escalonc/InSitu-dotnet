// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SourceType.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   The source type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Data.Models.EvaluationPart
{
    /// <summary>
    /// The source type.
    /// </summary>
    public class SourceType
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
        /// Gets or sets the area type.
        /// </summary>
        public virtual AreaType AreaType { get; set; }
    }
}
