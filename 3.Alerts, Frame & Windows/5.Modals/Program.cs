using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _5.Modals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/modal-dialogs");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            modals(driver);
            Thread.Sleep(2000);

            Thread.Sleep(20000);

            Console.Write("Test Case Closed:");
        }

        static void modals(IWebDriver driver)
        {
            IWebElement small_modalBTN = driver.FindElement(By.XPath("//button[@id='showSmallModal']"));
            small_modalBTN.Click();
            Thread.Sleep(1500);

            IWebElement close_modalBTN_1 = driver.FindElement(By.XPath("//button[@id='closeSmallModal']"));
            close_modalBTN_1.Click();
            Thread.Sleep(1500);

            IWebElement large_modalBTN = driver.FindElement(By.XPath("//button[@id='showLargeModal']"));
            large_modalBTN.Click();
            Thread.Sleep(1500);

            IWebElement close_modalBTN_2 = driver.FindElement(By.XPath("//button[@id='closeLargeModal']"));
            close_modalBTN_2.Click();
            Thread.Sleep(1500);

        }
    }
}
