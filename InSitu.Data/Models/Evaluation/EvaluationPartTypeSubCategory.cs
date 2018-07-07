// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EvaluationPartSubCategory.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   Defines the EvaluationPartSubCategory type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Data.Models.Evaluation
{
    using System.Collections.Generic;

    using InSitu.Data.Models.EvaluationPart;
    using InSitu.Data.Models.Parts;

    /// <summary>
    /// The evaluation part sub category.
    /// </summary>
    public class EvaluationPartTypeSubCategory
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
    }
}
