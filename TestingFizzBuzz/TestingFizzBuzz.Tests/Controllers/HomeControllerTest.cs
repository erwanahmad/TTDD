using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingFizzBuzz;
using TestingFizzBuzz.Controllers;

namespace TestingFizzBuzz.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Dikirim1Diterima1()
        {
            // Arange 
            FizzBuzzController controller = new FizzBuzzController();

            // Act
            ViewResult result = controller.Index(1) as ViewResult;
            string expected = "1";
            string actual = result.ViewBag.OutPut;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Dikirim3Diterima12Fizz()
        {
            // Arange 
            FizzBuzzController controller = new FizzBuzzController();

            // Act
            ViewResult result = controller.Index(3) as ViewResult;
            string expected = "12Fizz";
            string actual = result.ViewBag.OutPut;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Dikirim5Diterima12Fizz4Buzz()
        {
            // Arange 
            FizzBuzzController controller = new FizzBuzzController();

            // Act
            ViewResult sut = controller.Index(5) as ViewResult; // sut - system under test
            string expected = "12Fizz4Buzz";
            string actual = sut.ViewBag.OutPut;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Dikirim15Diterima12Fizz4Buzz6Dst()
        {
            // Arange 
            FizzBuzzController controller = new FizzBuzzController();

            // Act
            ViewResult sut = controller.Index(15) as ViewResult; // sut - system under test
            string expected = "12Fizz4BuzzFizz78FizzBuzz11Fizz1314FizzBuzz";
            string actual = sut.ViewBag.OutPut;

            // Assert
            Assert.AreEqual(expected, actual);
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
