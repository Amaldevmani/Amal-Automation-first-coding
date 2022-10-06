using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

IWebDriver driver = new ChromeDriver();
// navigate to the turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
driver.Manage().Window.Maximize();
Thread.Sleep(1000);
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
// create time record

//navigate to time and material page
IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationDropdown.Click();
Thread.Sleep(1000);
IWebElement timeAndMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
timeAndMaterial.Click();
//click on create new button
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
if(newlist.Text == "createtest")
{
    Console.WriteLine("New time record Created");
}
else
{
    Console.WriteLine("New record hasn't created");
}
// Edit a time record
IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
editButton.Click();
IWebElement codeTextboxEdit = driver.FindElement(By.Id("Code"));
codeTextboxEdit.SendKeys(" Change");
