// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InSituContext.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   The in situ context.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Data.Contexts
{
    using System.Data.Entity;

    using InSitu.Data.Models.CarInformation;
    using InSitu.Data.Models.Evaluation;
    using InSitu.Data.Models.EvaluationPart;
    using InSitu.Data.Models.Parts;
    using InSitu.Data.Models.Person;

    /// <inheritdoc />
    /// <summary>
    /// The in situ context.
    /// </summary>
    public class InSituContext : DbContext
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="InSituContext"/> class.
        /// </summary>
        public InSituContext()
            : base("DefultConnection")
        {
        }

        /// <summary>
        /// Gets or sets the brands.
        /// </summary>
        public virtual DbSet<Brand> Brands { get; set; }

        /// <summary>
        /// Gets or sets the cars.
        /// </summary>
        public virtual DbSet<Car> Cars { get; set; }

        /// <summary>
        /// Gets or sets the car models.
        /// </summary>
        public virtual DbSet<CarModel> CarModels { get; set; }

        /// <summary>
        /// Gets or sets the car types.
        /// </summary>
        public virtual DbSet<CarType> CarTypes { get; set; }

        /// <summary>
        /// Gets or sets the fuels.
        /// </summary>
        public virtual DbSet<FuelType> FuelTypes { get; set; }

        /// <summary>
        /// Gets or sets the paints.
        /// </summary>
        public virtual DbSet<PaintType> PaintTypes { get; set; }

        /// <summary>
        /// Gets or sets the sizes.
        /// </summary>
        public virtual DbSet<Size> Sizes { get; set; }

        /// <summary>
        /// Gets or sets the use types.
        /// </summary>
        public virtual DbSet<UseType> UseTypes { get; set; }

        /// <summary>
        /// Gets or sets the versions.
        /// </summary>
        public virtual DbSet<Version> Versions { get; set; }

        /// <summary>
        /// Gets or sets the appraisals.
        /// </summary>
        public virtual DbSet<Appraisal> Appraisals { get; set; }

        /// <summary>
        /// Gets or sets the evaluation part type categories.
        /// </summary>
        public virtual DbSet<EvaluationPartTypeCategory> EvaluationPartTypeCategories { get; set; }

        /// <summary>
        /// Gets or sets the evaluation part type categories.
        /// </summary>
        public virtual DbSet<EvaluationPartTypeSubCategory> EvaluationPartTypeSubCategories { get; set; }

        /// <summary>
        /// Gets or sets the area types.
        /// </summary>
        public virtual DbSet<AreaType> AreaTypes { get; set; }

        /// <summary>
        /// Gets or sets the evaluation parts.
        /// </summary>
        public virtual DbSet<EvaluationPart> EvaluationParts { get; set; }

        /// <summary>
        /// Gets or sets the construction types.
        /// </summary>
        public virtual DbSet<ConstructionType> ConstructionTypes { get; set; }

        /// <summary>
        /// Gets or sets the source types.
        /// </summary>
        public virtual DbSet<SourceType> SourceTypes { get; set; }

        /// <summary>
        /// Gets or sets the special evaluation types.
        /// </summary>
        public virtual DbSet<SpecialEvaluationType> SpecialEvaluationTypes { get; set; }

        /// <summary>
        /// Gets or sets the parts.
        /// </summary>
        public virtual DbSet<Part> Parts { get; set; }

        /// <summary>
        /// Gets or sets the part types.
        /// </summary>
        public virtual DbSet<PartType> PartTypes { get; set; }

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        public virtual DbSet<PartTypeCategory> PartTypeCategories { get; set; }

        /// <summary>
        /// Gets or sets the part type sub categories.
        /// </summary>
        public virtual DbSet<PartTypeSubCategory> PartTypeSubCategories { get; set; }

        /// <summary>
        /// Gets or sets the sub categories.
        /// </summary>
        public virtual DbSet<PartTypeSubCategory> SubCategories { get; set; }

        /// <summary>
        /// Gets or sets the contacts.
        /// </summary>
        public virtual DbSet<Contact> Contacts { get; set; }

        /// <summary>
        /// Gets or sets the persons.
        /// </summary>
        public virtual DbSet<Person> Persons { get; set; }
    }
}
