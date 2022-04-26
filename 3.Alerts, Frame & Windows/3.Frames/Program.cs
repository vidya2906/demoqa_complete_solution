using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3.Frames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/frames");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            frames(driver);
            Thread.Sleep(2000);

            Thread.Sleep(20000);

            Console.Write("Test Case Closed:");
        }

        static void frames(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(1500);

            Driver.FindElement(By.XPath("//span[text()='Frames']")).Click();
            Thread.Sleep(1500);

            Driver.SwitchTo().Frame(0);
            Thread.Sleep(1500);

            Driver.SwitchTo().DefaultContent();
            Thread.Sleep(1500);

            Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//iframe[@id='frame2']")));
            Thread.Sleep(1500);

            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(1500);

            js.ExecuteScript("window.scrollBy(200,0)");
            Thread.Sleep(1500);

            js.ExecuteScript("window.scrollBy(0,-300)");
            Thread.Sleep(1500);

            js.ExecuteScript("window.scrollBy(-200,0)");
            Thread.Sleep(1500);

        }
    }
}
