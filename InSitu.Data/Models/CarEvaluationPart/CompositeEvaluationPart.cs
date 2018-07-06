// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CompositeEvaluationPart.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   Defines the CompositeEvaluationPart type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Data.Models.CarEvaluationPart
{
    using System.Collections.Generic;

    /// <inheritdoc />
    /// <summary>
    /// The composite evaluation part.
    /// </summary>
    public class CompositeEvaluationPart : EvaluationPart
    {
        /// <summary>
        /// Gets or sets the single state evaluation parts.
        /// </summary>
        public virtual ICollection<SingleStateEvaluationPart> SingleStateEvaluationParts { get; set; } = new HashSet<SingleStateEvaluationPart>();
    }
}
