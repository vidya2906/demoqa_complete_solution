using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _5.Progress_bar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/progress-bar");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            progress_bar(driver);
            Thread.Sleep(2000);

            //date_time(driver);
            //Thread.Sleep(2000);

            Thread.Sleep(20000);

            Console.Write("Test Case Closed:");
        }

        static void progress_bar(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            IWebElement startBTN = driver.FindElement(By.XPath("//button[@id='startStopButton']"));
            startBTN.Click();
            Thread.Sleep(15000);

            //IWebElement stopBTN = driver.FindElement(By.XPath("//button[@id='startStopButton']"));
            //stopBTN.Click();
            //Thread.Sleep(2000);

            IWebElement resetBTN = driver.FindElement(By.XPath("//button[@id='resetButton']"));
            resetBTN.Click();
            Thread.Sleep(5000);
        }
    }
}
