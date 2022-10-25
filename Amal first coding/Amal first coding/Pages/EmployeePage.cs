using Amal_first_coding.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Amal_first_coding.Pages
{
    public class EmployeePage
    {
        public void CreateEmployee(IWebDriver driver)
        {
            //click on create button
            IWebElement createButton = driver.FindElement(By.XPath("//a[text()='Create']"));
            createButton.Click();
            //input text in name textbox
            IWebElement employeeName = driver.FindElement(By.Id("Name"));
            employeeName.SendKeys("Amal");

            //input text in username textbox
            IWebElement employeeUserName = driver.FindElement(By.Id("Username"));
            employeeUserName.SendKeys("Amal1");
            //input number in contact textbox
            IWebElement contact = driver.FindElement(By.Id("ContactDisplay"));
            contact.SendKeys("1212");
            //input text in password textbox
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("Amaldev@123");
            //retype text in retypepassword textbox
            IWebElement retypePassword = driver.FindElement(By.Id("RetypePassword"));
            retypePassword.SendKeys("Amaldev@123");
            //input text vehicle textbox
            IWebElement vehicle = driver.FindElement(By.Name("VehicleId_input"));
            vehicle.SendKeys("Toyota");
            //input text in group txtbox
            IWebElement groups = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
            groups.Click();
            IWebElement groupValue = driver.FindElement(By.XPath("//li[@class='k-item' and text()='Tests']"));
            groupValue.Click();
            //click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
        }
       
        public void BackToList(IWebDriver driver)
        {
            IWebElement backToList = driver.FindElement(By.XPath("//a[@href='/User' and text()='Back to List']"));
            backToList.Click();
        }

        public void GoToLastPage(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, "XPath", "//span[text()='Go to the last page']", 2);
            IWebElement goToLastPage = driver.FindElement(By.XPath("//span[text()='Go to the last page']"));
            goToLastPage.Click();
        }


        public void EditEmployee(IWebDriver driver)
        {
            IWebElement lastEditBtn = driver.FindElement(By.XPath("(//table)[2]//tr[last()]/td[3]/a[1]"));
            lastEditBtn.Click();
            IWebElement employeeUserName = driver.FindElement(By.Id("Username"));
            employeeUserName.Clear();
            employeeUserName.SendKeys("Amal2");
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
        }
        public void DeleteEmployee(IWebDriver driver)
        {
            IWebElement lastDeleteBtn = driver.FindElement(By.XPath("(//table)[2]//tr[last()]/td[3]/a[2]"));
            lastDeleteBtn.Click();
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }
    }
}
