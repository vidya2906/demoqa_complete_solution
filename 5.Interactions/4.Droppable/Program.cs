using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4.Droppable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/droppable");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            SIMPLE_DROP(driver);
            Thread.Sleep(2000);

            ACCEPT_DROP(driver);
            Thread.Sleep(2000);

            PREVENT_DROP(driver);
            Thread.Sleep(2000);

            REVERT_DROP(driver);
            Thread.Sleep(2000);

            Thread.Sleep(20000);

            Console.Write("Test Case Closed:");
        }

        static void SIMPLE_DROP(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Actions a1 = new Actions(Driver);

            a1.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='draggable']"))).Build().Perform();
            Thread.Sleep(1500);

            Actions a2 = new Actions(Driver);

            a2.MoveToElement(Driver.FindElement(By.XPath("//div[@id='droppable']"))).Release().Perform();
            Thread.Sleep(1500);
        }

        static void ACCEPT_DROP(IWebDriver Driver)
        {
            Driver.FindElement(By.XPath("//a[@id='droppableExample-tab-accept']")).Click();
            Thread.Sleep(1500);

            Actions a = new Actions(Driver);

            a.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='acceptable']"))).Build().Perform();
            Thread.Sleep(1500);

            a.MoveToElement(Driver.FindElement(By.XPath("//div[@class='accept-drop-container']//div[@id='droppable']"))).Release().Perform();
            Thread.Sleep(1500);

            a.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='notAcceptable']"))).Build().Perform();
            Thread.Sleep(1500);

            a.MoveToElement(Driver.FindElement(By.XPath("//div[@class='accept-drop-container']//div[@id='droppable']"))).Release().Perform();
            Thread.Sleep(1500);
        }

        static void PREVENT_DROP(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Driver.FindElement(By.XPath("//a[@id='droppableExample-tab-preventPropogation']")).Click();
            Thread.Sleep(1500);

            js.ExecuteScript("window.scrollBy(0,250)");
            Thread.Sleep(1500);

            Actions ac = new Actions(Driver);

            ac.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='dragBox']"))).Build().Perform();
            Thread.Sleep(1500);

            ac.MoveToElement(Driver.FindElement(By.XPath("//div[@id='notGreedyDropBox']//p[text()='Outer droppable']"))).Release().Perform();
            Thread.Sleep(1500);

            ac.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='dragBox']"))).Build().Perform();
            Thread.Sleep(1500);

            ac.MoveToElement(Driver.FindElement(By.XPath("//div[@id='notGreedyInnerDropBox']"))).Release().Perform();
            Thread.Sleep(2500);

            ac.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='dragBox']"))).Build().Perform();
            Thread.Sleep(1500);

            ac.MoveToElement(Driver.FindElement(By.XPath("//div[@id='greedyDropBox']//p[text()='Outer droppable']"))).Release().Perform();
            Thread.Sleep(1500);

            ac.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='dragBox']"))).Build().Perform();
            Thread.Sleep(1500);

            ac.MoveToElement(Driver.FindElement(By.XPath("//div[@id='greedyDropBoxInner']"))).Release().Perform();
            Thread.Sleep(1500);
        }

        static void REVERT_DROP(IWebDriver Driver)
        {
            Driver.FindElement(By.XPath("//a[@id='droppableExample-tab-revertable']")).Click();
            Thread.Sleep(1500);

            Actions ac = new Actions(Driver);

            ac.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='notRevertable']"))).Build().Perform();
            Thread.Sleep(1500);

            ac.MoveToElement(Driver.FindElement(By.XPath("//div[@class='revertable-drop-container']//div[@id='droppable']"))).Release().Perform();
            Thread.Sleep(1500);
        }
    }
}
