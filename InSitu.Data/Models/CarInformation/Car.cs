// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Car.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   Defines the Car type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Data.Models.CarInformation
{
    using System.Collections.Generic;
    using System.Drawing;

    using InSitu.Data.Models.Parts;
    using InSitu.Data.Models.Person;

    /// <summary>
    /// The car.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        public ushort Year { get; set; }

        /// <summary>
        /// Gets or sets the vin.
        /// </summary>
        public string Vin { get; set; }

        /// <summary>
        /// Gets or sets the license plate.
        /// </summary>
        public string LicensePlate { get; set; }

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Gets or sets the brand.
        /// </summary>
        public Brand Brand { get; set; }

        /// <summary>
        /// Gets or sets the car model.
        /// </summary>
        public CarModel CarModel { get; set; }

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        public virtual CarVersion Version { get; set; }

        /// <summary>
        /// Gets or sets the car type.
        /// </summary>
        public virtual CarType CarType { get; set; }

        /// <summary>
        /// Gets or sets the fuel type.
        /// </summary>
        public virtual FuelType FuelType { get; set; }

        /// <summary>
        /// Gets or sets the paint type.
        /// </summary>
        public virtual PaintType PaintType { get; set; }

        /// <summary>
        /// Gets or sets the car size.
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets or sets the use type.
        /// </summary>
        public UseType UseType { get; set; }

        /// <summary>
        /// Gets or sets the person.
        /// </summary>
        public virtual Customer Customer { get; set; }

        /// <summary>
        /// Gets or sets the parts.
        /// </summary>
        public virtual ICollection<Part> Parts { get; set; } = new HashSet<Part>();
    }
}
