using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3.Date_picker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/date-picker");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            select_date_1(driver);
            Thread.Sleep(2000);

            date_time(driver);
            Thread.Sleep(2000);

            Thread.Sleep(20000);

            Console.Write("Test Case Closed:");
        }

        static void select_date_1(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            IWebElement dateBOX = driver.FindElement(By.XPath("//input[@id='datePickerMonthYearInput']"));
            dateBOX.Click();

            driver.FindElement(By.XPath("//button[normalize-space()='Next Month']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[normalize-space()='Next Month']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[normalize-space()='Next Month']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//select[@class='react-datepicker__year-select']")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//select[@class='react-datepicker__year-select']")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[text()='2000']")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[text()='29']")).Click();
            Thread.Sleep(1500);

            js.ExecuteScript("window.scrollBy(0,120)");
            Thread.Sleep(500);
        }

        static void date_time(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            IWebElement date_timeBOX = driver.FindElement(By.XPath("//input[@id='dateAndTimePickerInput']"));
            date_timeBOX.Click();

            driver.FindElement(By.XPath("//span[@class='react-datepicker__year-read-view--down-arrow']")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//*[text()='2019']")).Click();
            Thread.Sleep(500);

            driver.FindElement(By.XPath("//span[@class='react-datepicker__month-read-view--down-arrow']")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//*[text()='August']")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//*[text()='15']")).Click();
            Thread.Sleep(1000);

            IWebElement timeUpArrowBTN = driver.FindElement(By.XPath("//li[normalize-space()='10:00']"));
            timeUpArrowBTN.Click();
            Thread.Sleep(500);
        }
    }
}
