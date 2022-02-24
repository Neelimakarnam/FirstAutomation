using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace FirstAutomation
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //open chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //launch turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/account/login");
            // identifiy username textbox
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");
            //identifiy password textbox
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");
            //login button
            IWebElement logginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            logginButton.Click();
            //check if your logged successfully
            IWebElement hellohari= driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            if(hellohari.Text=="hello hari")
            {
                Console.WriteLine("logged in successfully test passed");
            }
            else
            {
                Console.WriteLine("loggin failed,testc failed");



            }
            Console.WriteLine("Hello World");
        }
    }
}
