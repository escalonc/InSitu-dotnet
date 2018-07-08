// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MenuConfiguration.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   The menu configuration.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Web.Utilities.Menu
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// The menu configuration.
    /// </summary>
    public class MenuConfiguration
    {
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Gets or sets the groups.
        /// </summary>
        public List<Group> Groups { get; set; }
    }
}