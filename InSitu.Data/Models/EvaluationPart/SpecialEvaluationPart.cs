// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SpecialEvaluationPart.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   The special evaluation part.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Data.Models.EvaluationPart
{
    using System.Collections.Generic;

    /// <inheritdoc />
    /// <summary>
    /// The special evaluation part.
    /// </summary>
    public class SpecialEvaluationPart : EvaluationPart
    {
        /// <summary>
        /// Gets or sets the special evaluation types.
        /// </summary>
        public virtual ICollection<SpecialEvaluationType> SpecialEvaluationTypes { get; set; } = new HashSet<SpecialEvaluationType>();
    }
}
