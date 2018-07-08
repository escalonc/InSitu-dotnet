// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Item.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   Defines the Item type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Web.Utilities.Menu
{
    using System.Xml.Serialization;

    /// <inheritdoc />
    /// <summary>
    /// The item.
    /// </summary>
    public class Item : BaseItem
    {
        /// <summary>
        /// Gets or sets the controller.
        /// </summary>
        public string Controller { get; set; }

        /// <summary>
        /// Gets or sets the action.
        /// </summary>
        public string Action { get; set; }
    }
}