using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _5.Buttons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.Navigate().GoToUrl("https://demoqa.com/buttons");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            buttons(driver);

            Console.Write("Test Case Closed:");

            Task.Delay(120000).Wait();

            driver.Close();
            driver.Quit();
        }

        static void buttons(IWebDriver Driver)
        {
            Actions a = new Actions(Driver);

            a.MoveToElement(Driver.FindElement(By.Id("doubleClickBtn"))).DoubleClick().Build().Perform();
            Thread.Sleep(2000);

            a.MoveToElement(Driver.FindElement(By.Id("rightClickBtn"))).ContextClick().Build().Perform();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//*[text()='Click Me']")).Click();
        }
    }
}
