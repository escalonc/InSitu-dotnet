// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Customer.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   Defines the Customer type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Data.Models.Person
{
    using System.Collections.Generic;

    using InSitu.Data.Models.CarInformation;

    /// <inheritdoc />
    /// <summary>
    /// The customer.
    /// </summary>
    public class Customer : Person
    {
        /// <summary>
        /// Gets or sets the cars.
        /// </summary>
        public virtual ICollection<Car> Cars { get; set; } = new HashSet<Car>();
    }
}
