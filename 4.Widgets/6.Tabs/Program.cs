using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _6.Tabs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/tabs");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            tabs(driver);
            Thread.Sleep(2000);

            //date_time(driver);
            //Thread.Sleep(2000);

            Thread.Sleep(20000);

            Console.Write("Test Case Closed:");
        }

        static void tabs(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("window.scrollBy(0,150)");
            Thread.Sleep(1500);

            IWebElement what_TAB = driver.FindElement(By.XPath("//a[@id='demo-tab-what']"));
            IWebElement origin_TAB = driver.FindElement(By.XPath("//a[@id='demo-tab-origin']")); 
            IWebElement use_TAB = driver.FindElement(By.XPath("//a[@id='demo-tab-use']"));

            //All 3 tabs selected, now switch between them-->
            origin_TAB.Click();
            Thread.Sleep(2000);

            use_TAB.Click();
            Thread.Sleep(2000);

            what_TAB.Click();
            Thread.Sleep(2000);

            use_TAB.Click();
            Thread.Sleep(2000);
        }
    }
}
