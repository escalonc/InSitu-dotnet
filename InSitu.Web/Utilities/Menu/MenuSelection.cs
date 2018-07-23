using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InSitu.Web.Utilities.Menu
{
    using System.Web.Mvc;

    /// <summary>
    /// Utility for menu selection.
    /// </summary>
    public static class MenuSelection
    {
        /// <summary>
        /// highlights current menu item.
        /// </summary>
        /// <param name="html">
        /// A html razor helper.
        /// </param>
        /// <param name="controller">
        /// A controller.
        /// </param>
        /// <param name="action">
        /// An Action.
        /// </param>
        /// <param name="className">
        /// The class Name.
        /// </param>
        /// <returns>
        /// A css class
        /// </returns>
        public static string IsActive(
            this HtmlHelper html,
            string controller,
            string action, 
            string className)
        {
            var routeData = html.ViewContext.RouteData;

            var routeAction = routeData.Values["action"].ToString();
            var routeController = routeData.Values["controller"].ToString();

            var returnActive = controller == routeController &&
                               action == routeAction;

            return returnActive ? className : string.Empty;
        }

        /// <summary>
        /// The is in group.
        /// </summary>
        /// <param name="group">
        /// The group.
        /// </param>
        /// <param name="controller">
        /// The controller.
        /// </param>
        /// <param name="action">
        /// The action.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public static bool IsGroupActive(this HtmlHelper html, Group group)
        {
            var routeData = html.ViewContext.RouteData;

            var routeAction = routeData.Values["action"].ToString();
            var routeController = routeData.Values["controller"].ToString();

            return group.Items.Exists(x => x.Controller == routeController && x.Action == routeAction);
        }
    }
}