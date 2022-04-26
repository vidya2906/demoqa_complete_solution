using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _6.Links
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

            driver.Navigate().GoToUrl("https://demoqa.com/links");
            
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            link(driver);

            Console.Write("Test Case Closed:");

            Task.Delay(120000).Wait();

            driver.Close();
            driver.Quit();
        }

        static void link(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.FindElement(By.Id("simpleLink")).Click();
            Thread.Sleep(2000);

            p = driver.WindowHandles[0];
            c = driver.WindowHandles[1];

            driver.SwitchTo().Window(c);
            driver.Close();
            Thread.Sleep(2000);

            driver.SwitchTo().Window(p);

            driver.FindElement(By.Id("dynamicLink")).Click();
            Thread.Sleep(2000);

            c = driver.WindowHandles[1];

            driver.SwitchTo().Window(c);
            driver.Close();

            Thread.Sleep(2000);
            driver.SwitchTo().Window(p);

            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);


            driver.FindElement(By.Id("created")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.Id("no-content")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("moved")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.Id("bad-request")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.Id("unauthorized")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.Id("forbidden")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.Id("invalid-url")).Click();
        }    
    }
}