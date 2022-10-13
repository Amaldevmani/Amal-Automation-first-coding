using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amal_first_coding.Pages
{
   public class TmPage
    {
        public void CreateTM(IWebDriver driver) 
        {
            // click on create new button
            IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createButton.Click();

            //select time from the typecode dropedown
            IWebElement typeCodeDropedown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typeCodeDropedown.Click();
            Thread.Sleep(1000);
            IWebElement TimeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            TimeOption.Click();


            //enter code into the code text box
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("createtest");

            //enter description in the description textbox
            IWebElement description = driver.FindElement(By.Id("Description"));
            description.SendKeys("testing only");

            //enter price in the price per unit text box
            IWebElement tag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            tag.Click();
            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("23");

            //click on save
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2000);

            //check if new time record created successfully.
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();
            IWebElement newlist = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (newlist.Text == "createtest")
            {
                Console.WriteLine("New time record Created");
            }
            else
            {
                Console.WriteLine("New record hasn't created");
            }

        }
        public void EditTM(IWebDriver driver)
        {
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            IWebElement codeTextboxEdit = driver.FindElement(By.Id("Code"));
            codeTextboxEdit.Clear();
            codeTextboxEdit.SendKeys("Change");

            //click on save
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();
            IWebElement newlist2 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (newlist2.Text == "Change")
            {
                Console.WriteLine("New time record edited successfully");
            }
            else
            {
                Console.WriteLine("New record is not edited successfully");
            }
        }
        public void DeleteTM(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(2000);
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();
            IWebElement newlist3 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (newlist3.Text == "Change")
            {
                Console.WriteLine("Record is not deleted");
            }
            else
            {
                Console.WriteLine("record deleted Successfully");
            }

        }

    }
}
