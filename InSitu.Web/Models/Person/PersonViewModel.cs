using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InSitu.Web.Models.Person
{
    using InSitu.Data.Models.Person;

    public class PersonViewModel
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
        public virtual ICollection<ContactViewModel> Contacts { get; set; } = new HashSet<ContactViewModel>();
    }
}