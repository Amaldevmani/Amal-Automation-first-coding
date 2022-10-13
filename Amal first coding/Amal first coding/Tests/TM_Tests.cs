using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Amal_first_coding.Pages;

IWebDriver driver = new ChromeDriver();

LoginPage loginPageObj = new LoginPage();
loginPageObj.Loginsteps(driver);
HomePage homePageObj = new HomePage();
homePageObj.GoToTMPage(driver);
TmPage tmPageObj = new TmPage();
tmPageObj.CreateTM(driver);
tmPageObj.EditTM(driver);   
tmPageObj.DeleteTM(driver); 
    
    









