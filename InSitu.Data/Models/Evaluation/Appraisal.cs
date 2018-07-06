// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Appraisal.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   The appraisal.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Data.Models.Evaluation
{
    using System.Collections.Generic;

    using InSitu.Data.Models.CarEvaluationPart;
    using InSitu.Data.Models.CarInformation;
    using InSitu.Data.Models.Person;

    /// <summary>
    /// The appraisal.
    /// </summary>
    public class Appraisal
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the car.
        /// </summary>
        public virtual Car Car { get; set; }

        /// <summary>
        /// Gets or sets the person.
        /// </summary>
        public virtual Person Person { get; set; }

        /// <summary>
        /// Gets or sets the evaluation parts.
        /// </summary>
        public virtual ICollection<EvaluationPart> EvaluationParts { get; set; } = new HashSet<EvaluationPart>();
    }
}
