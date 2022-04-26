using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2.Alerts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/alerts");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            alert1(driver);
            Thread.Sleep(2000);

            //alert2(driver);
            //Thread.Sleep(2000);

            alert3(driver);
            Thread.Sleep(2000);

            alert4(driver);
            Thread.Sleep(2000);

            Thread.Sleep(20000);

            Console.Write("Test Case Closed:");
        }

        static void alert1(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("window.scrollBy(0,150)");
            Thread.Sleep(500);

            IWebElement clickBTN_1 = driver.FindElement(By.XPath("//button[@id='alertButton']"));
            clickBTN_1.Click();
            Thread.Sleep(1500);

            //void Accept() // To click on the ‘OK’ button of the alert.
            driver.SwitchTo().Alert().Accept();

        }

        //static void alert2(IWebDriver driver)
        //{
        //    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

        //    IWebElement clickBTN_2 = driver.FindElement(By.XPath("//button[@id='timerAlertButton']"));
        //    clickBTN_2.Click();
        //    //Thread.Sleep(5000); //timer is of 5 secomds

        //    Thread.Sleep(1500);
        //    //void Accept() // To click on the ‘OK’ button of the alert.
        //    driver.SwitchTo().Alert().Accept();

        //}

        static void alert3(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("window.scrollBy(0,150)");
            Thread.Sleep(500);


            IWebElement clickBTN_3 = driver.FindElement(By.XPath("//button[@id='confirmButton']"));
            clickBTN_3.Click();
            Thread.Sleep(1500);

            //void Accept() // To click on the ‘OK’ button of the alert.
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(1500);

            clickBTN_3.Click();
            Thread.Sleep(1500);
            driver.SwitchTo().Alert().Dismiss();


        }

        static void alert4(IWebDriver driver)
        {
            String text = "Demo text";

            IWebElement clickBTN_4 = driver.FindElement(By.XPath("//button[@id='promtButton']"));
            clickBTN_4.Click();
            Thread.Sleep(1500);

            driver.SwitchTo().Alert().SendKeys(text);
            Thread.Sleep(1500);

            //void Accept() // To click on the ‘OK’ button of the alert.
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(1500);

            clickBTN_4.Click();
            Thread.Sleep(1500);
            driver.SwitchTo().Alert().SendKeys(text);
            Thread.Sleep(1500);
            driver.SwitchTo().Alert().Dismiss();
        }
    }
}
