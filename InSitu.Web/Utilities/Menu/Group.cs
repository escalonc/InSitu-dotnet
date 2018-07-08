// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Group.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   Defines the Group type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Web.Utilities.Menu
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <inheritdoc />
    /// <summary>
    /// The group.
    /// </summary>
    public class Group : BaseItem
    {
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();
    }
}