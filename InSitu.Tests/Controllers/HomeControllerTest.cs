// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeControllerTest.cs" company="Walltech">
//   Copyright (c) Walltech. All rights reserved.
// </copyright>
// <summary>
//   Defines the HomeControllerTest type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace InSitu.Tests.Controllers
{
    using System.Web.Mvc;

    using InSitu.Web.Controllers;

    using NUnit.Framework;

    [TestFixture]
    public class HomeControllerTest
    {
        [TestCase]
        public void Index()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestCase]
        public void About()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestCase]
        public void Contact()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
