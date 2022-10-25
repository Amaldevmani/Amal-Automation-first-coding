using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Amal_first_coding.Pages;
using NUnit.Framework;
using System.ComponentModel;
using Amal_first_coding.Utilities;
using DescriptionAttribute = NUnit.Framework.DescriptionAttribute;

namespace Amal_first_coding.Tests
{
    [TestFixture]
    [Parallelizable]
    public class TM_Tests : CommonDriver
    {
       HomePage homePageObj = new HomePage();            
        
        [Test, Order(1), Description("Test to create a new TM record")]
        public void CreateTMTest()
        {
            homePageObj.GoToTMPage(driver);
            TmPage tmPageObj = new TmPage();
            tmPageObj.CreateTM(driver);
        }
        [Test, Order(2), Description("Test to edit the latest new TM record")]
        public void EditTMTest()
        {
            homePageObj.GoToTMPage(driver);
            TmPage tmPageObj = new TmPage();
            tmPageObj.EditTM(driver);
        }
        [Test, Order(3), Description("Test to delete the latest TM record")]
        public void DeleteTMTest()
        {
            homePageObj.GoToTMPage(driver);
            TmPage tmPageObj = new TmPage();
            tmPageObj.DeleteTM(driver);
        }
    }
}