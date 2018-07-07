// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SingleStateEvaluationPart.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   The single state evaluation part.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Data.Models.EvaluationPart
{
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The evaluation part state.
    /// </summary>
    public enum EvaluationStatePart
    {
        /// <summary>
        /// The good.
        /// </summary>
        Good,

        /// <summary>
        /// The regular.
        /// </summary>
        Regular,

        /// <summary>
        /// The bad.
        /// </summary>
        Bad
    }

    /// <inheritdoc />
    /// <summary>
    /// The single state evaluation part.
    /// </summary>
    [Table("SingleStateEvaluationParts")]
    public class SingleStateEvaluationPart : EvaluationPart
    {
        /// <summary>
        /// Gets or sets the evaluation state part.
        /// </summary>
        public EvaluationStatePart EvaluationStatePart { get; set; }
    }
}
