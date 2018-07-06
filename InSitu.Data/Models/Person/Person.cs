// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Person.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   The person.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Data.Models.Person
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The gender.
    /// </summary>
    public enum Gender
    {
        /// <summary>
        /// The male.
        /// </summary>
        Male,

        /// <summary>
        /// The female.
        /// </summary>
        Female
    }

    /// <summary>
    /// The person.
    /// </summary>
    public abstract class Person
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identification number.
        /// </summary>
        public string IdentificationNumber { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the middle name.
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the surnames.
        /// </summary>
        public string Surnames { get; set; }

        /// <summary>
        /// Gets or sets the birthdate.
        /// </summary>
        public DateTimeOffset Birthdate { get; set; }

        /// <summary>
        /// Gets or sets the city of residence.
        /// </summary>
        public string CityOfResidence { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Gets or sets the contacts.
        /// </summary>
        public virtual ICollection<Contact> Contacts { get; set; } = new HashSet<Contact>();
    }
}
