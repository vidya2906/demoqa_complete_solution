using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3.Radio_button
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.Navigate().GoToUrl("https://demoqa.com/radio-button");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            radioButton(driver);

            Console.Write("Test Case Closed:");

            Task.Delay(120000).Wait();

            driver.Close();
            driver.Quit();
        }

        static void radioButton(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.FindElements(By.XPath("//label[contains(@class,'custom-control')]"))[0].Click(); //click on YES
            Thread.Sleep(1000);

            driver.FindElements(By.XPath("//label[contains(@class,'custom-control')]"))[1].Click(); //click on IMPRESSIVE
            Thread.Sleep(1000);

            //driver.FindElements(By.XPath("//label[contains(@class,'custom-control')]"))[2].Click(); //can't click on NO

        }
    }
}
