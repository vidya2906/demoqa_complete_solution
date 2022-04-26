using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1.Accordian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/accordian");

            //driver.Manage().Window.Maximize();
            //Thread.Sleep(2000);

            accordian_test(driver);
            Thread.Sleep(2000);

            Thread.Sleep(20000);

            Console.Write("Test Case Closed:");
        }

        static void accordian_test(IWebDriver driver)
        {
            IWebElement acc_1 = driver.FindElement(By.XPath("//div[normalize-space()='What is Lorem Ipsum?']"));
            acc_1.Click();
            Thread.Sleep(1500);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("window.scrollBy(0,150)");
            Thread.Sleep(500);

            IWebElement acc_2 = driver.FindElement(By.XPath("//div[normalize-space()='Where does it come from?']"));
            acc_2.Click();
            Thread.Sleep(1500);

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(500);

            IWebElement acc_3 = driver.FindElement(By.XPath("//div[normalize-space()='Why do we use it?']"));
            acc_3.Click();
            Thread.Sleep(1500);
            acc_3.Click();

        }        
    }
}
