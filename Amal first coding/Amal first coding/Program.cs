using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

IWebDriver driver = new ChromeDriver();
// navigate to the turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
driver.Manage().Window.Maximize();
// identify username text box and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");
// identify password text box and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");
// identify login button and click on it
IWebElement logginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
logginbutton.Click();
// check if user logged in successfully
IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
if (hellohari.Text == "Hello hari!")
{
    Console.WriteLine("Logged in Successfully, Test passed");
}
else
{
    Console.WriteLine("logged in Failed, Test failed");

}