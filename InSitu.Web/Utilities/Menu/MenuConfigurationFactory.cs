// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MenuConfigurationFactory.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   Defines the MenuConfigurationFactory type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Web.Utilities.Menu
{
    using System.IO;
    using System.Web.Hosting;
    using System.Xml.Serialization;

    /// <summary>
    /// The menu configuration factory.
    /// </summary>
    public class MenuConfigurationFactory
    {
        /// <summary>
        /// The create.
        /// </summary>
        /// <returns>
        /// The <see cref="MenuConfiguration"/>.
        /// </returns>
        public static MenuConfiguration Create()
        {
            MenuConfiguration menu;
            var xmlPath = HostingEnvironment.MapPath(Properties.Settings.Default.MenuConfigurationPath);
            var serializer = new XmlSerializer(typeof(MenuConfiguration));
            using (var stream = new StreamReader(xmlPath))
            {
                menu = serializer.Deserialize(stream) as MenuConfiguration;
            }

            return menu;
        }
    }
}