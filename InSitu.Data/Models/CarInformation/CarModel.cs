﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CarModel.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   Defines the CarModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Data.Models.CarInformation
{
    using System.Collections.Generic;

    /// <summary>
    /// The model.
    /// </summary>
    public class CarModel
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
        /// Gets or sets the cars.
        /// </summary>
        public virtual ICollection<Car> Cars { get; set; } = new HashSet<Car>();
    }
}
