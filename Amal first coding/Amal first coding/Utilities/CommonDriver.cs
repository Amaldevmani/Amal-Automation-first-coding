using Amal_first_coding.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amal_first_coding.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;

        [OneTimeSetUp]
        public void LoginActions()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.Loginsteps(driver);
        }

        [OneTimeTearDown]
        public void ClosetestRun()
        {
            driver.Close();
        }
    }
}
