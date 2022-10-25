using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amal_first_coding.Pages;
using NUnit.Framework;
using Amal_first_coding.Utilities;

namespace Amal_first_coding.Tests
{
    [TestFixture]
    [Parallelizable]
    public class EmployeeTests : CommonDriver
    {
        HomePage homePageObj = new HomePage();
        
        [Test, Order(1), Description("Test to create a new Employee record")]
        public void CreateEmployeeTest1()
        {
            homePageObj.GoToEmployeePage(driver);
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.CreateEmployee(driver);   
        }

        [Test, Order(2), Description("Test to edit the latest Employee record")]
        public void EditEmployeeTest1()
        {
            homePageObj.GoToEmployeePage(driver);
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.GoToLastPage(driver);
            employeePageObj.EditEmployee(driver);
        }

        [Test, Order(3), Description("Test to delete the latest Employee record")]
        public void DeleteEmployeeTest1()
        {
            homePageObj.GoToEmployeePage(driver);
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.GoToLastPage(driver);
            employeePageObj.DeleteEmployee(driver);

        }        
    }
}

