// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OdataUrl.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   The odata url.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace System.Web.Mvc
{
    using Microsoft.AspNet.OData.Routing;
    using Microsoft.OData.UriParser;
    using Web.Routing;

    /// <summary>
    /// The odata url.
    /// </summary>
    public static class ODataUrlExtension
    {
        /// <summary>
        /// The path handler.
        /// </summary>
        private static readonly IODataPathHandler PathHandler = new DefaultODataPathHandler();

        /// <summary>
        /// The o data url.
        /// </summary>
        /// <param name="urlHelper">
        /// The url helper.
        /// </param>
        /// <param name="routeName">
        /// The route name.
        /// </param>
        /// <param name="segments">
        /// The segments.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string OdataUrl(this UrlHelper urlHelper, string routeName, params ODataPathSegment[] segments)
        {
            var odataPath = PathHandler.Link(new Microsoft.AspNet.OData.Routing.ODataPath(segments));
            return urlHelper.HttpRouteUrl(
                routeName,
                new RouteValueDictionary { { ODataRouteConstants.ODataPath, odataPath } });
        }
    }
}