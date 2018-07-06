// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GeneralEvaluationPart.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   Defines the GeneralEvaluationPart type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Data.Models.CarEvaluationPart
{
    using System.Collections.Generic;

    /// <inheritdoc />
    /// <summary>
    /// The general evaluation part.
    /// </summary>
    public class GeneralEvaluationPart : EvaluationPart
    {
        /// <summary>
        /// Gets or sets the construction types.
        /// </summary>
        public virtual ICollection<ConstructionType> ConstructionTypes { get; set; } = new HashSet<ConstructionType>();

        /// <summary>
        /// Gets or sets the source types.
        /// </summary>
        public virtual ICollection<SourceType> SourceTypes { get; set; } = new HashSet<SourceType>();
    }
}
