// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Evaluator.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   Defines the Evaluator type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Data.Models.Evaluation
{
    using System.Collections.Generic;

    using InSitu.Data.Models.Person;

    /// <inheritdoc />
    /// <summary>
    /// The evaluator.
    /// </summary>
    public class Evaluator : Person
    {
        /// <summary>
        /// Gets or sets the appraisals.
        /// </summary>
        public virtual ICollection<Appraisal> Appraisals { get; set; } = new HashSet<Appraisal>();
    }
}
