using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1.Browser_windows
{
    internal class Program
    {
        private static string p;
        private static string c;
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.Navigate().GoToUrl("https://demoqa.com/browser-windows");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            newTabBTN(driver);
            Thread.Sleep(1500);

            newWindowBTN(driver);
            Thread.Sleep(1500);

            newWindow_msgBTN(driver);

            Task.Delay(120000).Wait();

            Console.Write("Test Case Closed:");

            driver.Close();
            driver.Quit();
        }

        static void newTabBTN(IWebDriver Driver)
        {
            Driver.FindElement(By.XPath("//button[@id='tabButton']")).Click();
            Thread.Sleep(2000);
            p = Driver.WindowHandles[0];
            c = Driver.WindowHandles[1];
            Driver.SwitchTo().Window(c);
            Driver.Close();
            Thread.Sleep(2000);
            Driver.SwitchTo().Window(p);
        }

        static void newWindowBTN(IWebDriver Driver)
        {
            Driver.FindElement(By.XPath("//button[@id='windowButton']")).Click();
            Thread.Sleep(2000);
            c = Driver.WindowHandles[1];
            Driver.SwitchTo().Window(c);
            Driver.Close();
            Thread.Sleep(2000);
            Driver.SwitchTo().Window(p);           
            Thread.Sleep(2000);
        }

        static void newWindow_msgBTN(IWebDriver Driver)
        {
            Driver.FindElement(By.XPath("//button[@id='messageWindowButton']")).Click();
            Thread.Sleep(2000);
            c = Driver.WindowHandles[1];
            Driver.SwitchTo().Window(c);
            Driver.Close();
            Thread.Sleep(2000);
            Driver.SwitchTo().Window(p);
            Thread.Sleep(2000);
        }
    }
}
