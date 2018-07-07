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
    /// <summary>
    /// The evaluation part state.
    /// </summary>
    public enum EvaluationPartState
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
    public class SingleStateEvaluationPart : EvaluationPart
    {
        /// <summary>
        /// Gets or sets the evaluation part state.
        /// </summary>
        public EvaluationPartState EvaluationPartState { get; set; }
    }
}
