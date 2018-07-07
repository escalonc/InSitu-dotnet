// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GeneralEvaluationPart.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   Defines the GeneralEvaluationPart type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Data.Models.EvaluationPart
{
    using System.ComponentModel.DataAnnotations.Schema;

    /// <inheritdoc />
    /// <summary>
    /// The general evaluation part.
    /// </summary>
    [Table("GeneralEvaluationParts")]
    public class GeneralEvaluationPart : EvaluationPart
    {
        /// <summary>
        /// Gets or sets the evaluation state part.
        /// </summary>
        public EvaluationStatePart EvaluationStatePart { get; set; }

        /// <summary>
        /// Gets or sets the construction type.
        /// </summary>
        public virtual ConstructionType ConstructionType { get; set; }

        /// <summary>
        /// Gets or sets the source type.
        /// </summary>
        public virtual SourceType SourceType { get; set; }
    }
}
