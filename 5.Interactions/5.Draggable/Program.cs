using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _5.Draggable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/dragabble");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            simple(driver);
            Thread.Sleep(2000);

            axis(driver);
            Thread.Sleep(2000);

            container(driver);
            Thread.Sleep(2000);

            cursor(driver);
            Thread.Sleep(2000);

            Thread.Sleep(20000);

            Console.Write("Test Case Closed:");
        }

        static void simple(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Driver.FindElement(By.XPath("//span[text()='Dragabble']")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);

            Actions ac = new Actions(Driver);

            ac.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='dragBox']"))).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveByOffset(200, 150).Release().Perform();
            Thread.Sleep(2000);
        }

        static void axis(IWebDriver Driver)
        {
            Driver.FindElement(By.XPath("//a[@id='draggableExample-tab-axisRestriction']")).Click();
            Thread.Sleep(2000);

            Actions ac = new Actions(Driver);

            ac.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='restrictedX']"))).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveByOffset(100, 0).Release().Perform();
            Thread.Sleep(2000);

            ac.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='restrictedY']"))).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveByOffset(0, 200).Release().Perform();
            Thread.Sleep(2000);
        }

        static void container(IWebDriver Driver)
        {
            Driver.FindElement(By.XPath("//a[@id='draggableExample-tab-containerRestriction']")).Click();
            Thread.Sleep(2000);

            Actions ac = new Actions(Driver);

            ac.ClickAndHold(Driver.FindElement(By.XPath("//div[@class='draggable ui-widget-content ui-draggable ui-draggable-handle']"))).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveByOffset(200, 100).Release().Perform();
            Thread.Sleep(2000);

            ac.ClickAndHold(Driver.FindElement(By.XPath("//span[@class='ui-widget-header ui-draggable ui-draggable-handle']"))).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveByOffset(10, 30).Release().Perform();
            Thread.Sleep(2000);
        }

        static void cursor(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Driver.FindElement(By.XPath("//a[@id='draggableExample-tab-cursorStyle']")).Click();
            Thread.Sleep(2000);

            Actions ac = new Actions(Driver);

            ac.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='cursorCenter']"))).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveByOffset(100, 50).Release().Perform();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(2000);

            ac.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='cursorTopLeft']"))).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveByOffset(60, 20).Release().Perform();
            Thread.Sleep(2000);

            ac.ClickAndHold(Driver.FindElement(By.XPath("//span[text()='My cursor is at bottom']"))).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveByOffset(0, 100).Release().Perform();
            Thread.Sleep(2000);
        }
    }
}
