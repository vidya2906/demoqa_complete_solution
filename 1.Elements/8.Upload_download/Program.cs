using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _8.Upload_download
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.Navigate().GoToUrl("https://demoqa.com/upload-download");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            Upload_Download(driver);

            Console.Write("Test Case Closed:");

            Task.Delay(120000).Wait();

            driver.Close();
            driver.Quit();
        }

        static void Upload_Download(IWebDriver Driver)
        {
            Driver.FindElement(By.Id("downloadButton")).Click();
            Thread.Sleep(3000);
            Driver.FindElement(By.Id("uploadFile")).SendKeys(@"C:\Users\HP\Desktop\sampleFile.jpeg");
            Thread.Sleep(5000);
        }
    }
}
