using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3.Resizable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/resizable");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            size_limit(driver);
            Thread.Sleep(2000);

            resizable(driver);
            Thread.Sleep(2000);

            Thread.Sleep(20000);

            Console.Write("Test Case Closed:");
        }

        static void size_limit(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(1500);

            Actions a = new Actions(Driver);

            a.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='resizableBoxWithRestriction']//span")));
            Thread.Sleep(1500);

            a.MoveByOffset(200, 170).Release().Perform();
            Thread.Sleep(1500);
        }

        static void resizable(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(1500);

            Actions ac = new Actions(Driver);

            ac.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='resizable']//span")));
            Thread.Sleep(1500);

            ac.MoveByOffset(400, 300).Release().Perform();
            Thread.Sleep(1500);
        }
    }
}
