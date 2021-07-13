using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using phase4.Controllers;
using NUnit.Framework;
using NUnit.Compatibility;
using Assert = NUnit.Framework.Assert;

namespace phase4
{
    public class test
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Welecome to the pizza website.",result);
        }
    }

    public class AutomatedUITests : IDisposable
        {
            private readonly IWebDriver _driver;
            public AutomatedUITests()
            {
                _driver = new ChromeDriver();
            }
            public void Dispose()
            {
                _driver.Quit();
                _driver.Dispose();

            }
            public void Create_WrongModelData_ReturnsErrorMessage()
            {
                _driver.Navigate()
                .GoToUrl("https://localhost:5001/");

                _driver.FindElement(By.Id("Name"))
                    .SendKeys("BBQ,SMALL");


                _driver.FindElement(By.Id("submit"))
                    .Click();

            }
        }
    }

