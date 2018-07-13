// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseItem.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   The base item.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Web.Utilities.Menu
{
    using System.CodeDom;
    using System.Xml.Serialization;

    /// <summary>
    /// The base item.
    /// </summary>
    public abstract class BaseItem
    {
        /// <summary>
        /// Gets or sets the resource key.
        /// </summary>
        public string ResourceKey { get; set; }

        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets the role.
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// The text.
        /// </summary>
        public string Text => Resources.Menu.MenuResource.ResourceManager.GetString(this.ResourceKey);
    }
}