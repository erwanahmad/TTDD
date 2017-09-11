using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingMVC;
using TestingMVC.Controllers;
using Telerik.JustMock;
using TestingMVC.Models;

namespace TestingMVC.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void DimintaGenreFictionTampilkanitu()
        {
            // Arange
            var mockRepository = Mock.Create<Repository>();
            Mock.Arrange(() => mockRepository.GetAll())
                .Returns(new List<Book>
                {
                    new Book { Genre = "Fiction", Id = 1, Name = "Siapa Saya", Price = 200000},
                    new Book { Genre = "Fiction", Id = 2, Name = "Siapa Saya 2", Price = 100000},
                    new Book { Genre = "Mistery", Id = 3, Name = "Dono", Price = 50000}
                }).MustBeCalled();

            // Act
            HomeController controller = new HomeController(mockRepository); // buat repository di controller
            ViewResult hasil = controller.FindByGenre("Fiction");
            var model = hasil.Model as IEnumerable<Book>;

            // Assert
            Assert.AreEqual(2, model.Count());
            Assert.AreEqual("Siapa Saya", model.ToList()[0].Name);
            Assert.AreEqual("Siapa Saya 2", model.ToList()[1].Name);
        }

        [TestMethod]
        public void TampilHanyaGenreYangTerpilih()
        {
            // Arange
            var mockRepository = Mock.Create<Repository>();
            Mock.Arrange(() => mockRepository.GetAll())
                .Returns(new List<Book>
                {
                    new Book { Genre = "Fiction", Id = 1, Name = "Siapa Saya", Price = 200000},
                    new Book { Genre = "Fiction", Id = 2, Name = "Siapa Saya 2", Price = 100000},
                }).MustBeCalled();

            // Act
            HomeController controller = new HomeController(mockRepository); // buat repository di controller
            ViewResult hasil = controller.Index();
            var model = hasil.Model as IEnumerable<Book>;

            // Assert
            Assert.AreEqual(2, model.Count());
        }

        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
