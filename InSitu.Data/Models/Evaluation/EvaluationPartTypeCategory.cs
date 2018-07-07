// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EvaluationPartCategory.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   Defines the EvaluationPartCategory type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Data.Models.Evaluation
{
    using System.Collections.Generic;

    using InSitu.Data.Models.Parts;

    /// <summary>
    /// The evaluation part category.
    /// </summary>
    public class EvaluationPartTypeCategory
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
        /// Gets or sets the car parts.
        /// </summary>
        public virtual ICollection<PartType> PartTypes { get; set; } = new HashSet<PartType>();

        /// <summary>
        /// Gets or sets the sub categories.
        /// </summary>
        public virtual ICollection<EvaluationPartTypeSubCategory> EvaluationPartTypeSubCategories { get; set; } = new HashSet<EvaluationPartTypeSubCategory>();
    }
}
