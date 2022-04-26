using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4.Web_tables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.Navigate().GoToUrl("https://demoqa.com/webtables");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            webTables(driver);
            Thread.Sleep(2000);

            edit_webTables(driver);
            Thread.Sleep(2000);

            Delete(driver);
            Thread.Sleep(2000);

            Search(driver);
            Thread.Sleep(2000);

            Console.Write("Test Case Closed:");

            Task.Delay(120000).Wait();

            driver.Close();
            driver.Quit();
        }

        static void webTables(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            String firstName = "Vidya";
            String lastName = "Kumari";
            String Email = "sharmavidya939@gmail.com";
            string age = "22";
            string salary = "20000";
            String department = "Testing";

            //select ADD buton and then click on that
            driver.FindElement(By.Id("addNewRecordButton")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.Id("firstName")).SendKeys(firstName);
            Thread.Sleep(500);

            driver.FindElement(By.Id("lastName")).SendKeys(lastName);
            Thread.Sleep(500);

            driver.FindElement(By.Id("userEmail")).SendKeys(Email);
            Thread.Sleep(500);

            driver.FindElement(By.Id("age")).SendKeys(age);
            Thread.Sleep(500);

            driver.FindElement(By.Id("salary")).SendKeys(salary);
            Thread.Sleep(500);

            driver.FindElement(By.Id("department")).SendKeys(department);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("submit")).Click();

        }

        static void edit_webTables(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            string editfname = "xyz";

            driver.FindElement(By.Id("edit-record-1")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.Id("firstName")).Clear();
            Thread.Sleep(2000);

            driver.FindElement(By.Id("firstName")).SendKeys(editfname);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("submit")).Click();
        }

        static void Delete(IWebDriver driver)
        {
            driver.FindElement(By.Id("delete-record-1")).Click();
        }
        static void Search(IWebDriver driver)
        {
            string search = "vidya";
            driver.FindElement(By.Id("searchBox")).SendKeys(search);
            Thread.Sleep(2000);

            driver.FindElement(By.ClassName("input-group-text")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.Id("searchBox")).Clear();
            Thread.Sleep(2000);
        }
    }
}
