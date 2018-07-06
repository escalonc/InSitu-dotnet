// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EvaluationPart.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   Defines the EvaluationPart type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Data.Models.CarEvaluationPart
{
    using InSitu.Data.Models.CarParts;

    /// <summary>
    /// The evaluation part.
    /// </summary>
    public abstract class EvaluationPart
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the car part.
        /// </summary>
        public virtual Part CarPart { get; set; }
    }
}
