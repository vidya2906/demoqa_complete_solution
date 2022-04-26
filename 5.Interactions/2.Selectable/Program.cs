using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2.Selectable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/selectable");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            list_select(driver);
            Thread.Sleep(2000);

            grid_select(driver);
            Thread.Sleep(2000);

            Thread.Sleep(20000);

            Console.Write("Test Case Closed:");
        }

        static void list_select(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(1500);

            Driver.FindElement(By.XPath("//li[text()='Cras justo odio']")).Click();
            Thread.Sleep(1500);

            Driver.FindElement(By.XPath("//li[text()='Dapibus ac facilisis in']")).Click();
            Thread.Sleep(1500);

            Driver.FindElement(By.XPath("//li[normalize-space()='Morbi leo risus']")).Click();
            Thread.Sleep(1500);

            Driver.FindElement(By.XPath("//li[text()='Porta ac consectetur ac']")).Click();
            Thread.Sleep(1500);

            Driver.FindElement(By.XPath("//li[text()='Dapibus ac facilisis in']")).Click();
            Thread.Sleep(1500);

            Driver.FindElement(By.XPath("//li[text()='Porta ac consectetur ac']")).Click();
            Thread.Sleep(1500);

            Driver.FindElement(By.XPath("//li[text()='Cras justo odio']")).Click();
            Thread.Sleep(1500);
        }

        static void grid_select(IWebDriver Driver)
        {

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Driver.FindElement(By.XPath("//a[@id='demo-tab-grid']")).Click();
            Thread.Sleep(1500);

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(1500);

            Driver.FindElement(By.XPath("//li[text()='One']")).Click();
            Thread.Sleep(1500);

            Driver.FindElement(By.XPath("//li[text()='Nine']")).Click();
            Thread.Sleep(1500);

            Driver.FindElement(By.XPath("//li[text()='Two']")).Click();
            Thread.Sleep(1500);

            Driver.FindElement(By.XPath("//li[text()='Eight']")).Click();
            Thread.Sleep(1500);

            Driver.FindElement(By.XPath("//li[text()='Three']")).Click();
            Thread.Sleep(1500);

            Driver.FindElement(By.XPath("//li[text()='One']")).Click();
            Thread.Sleep(1500);

            Driver.FindElement(By.XPath("//li[text()='Nine']")).Click();
            Thread.Sleep(1500);

            Driver.FindElement(By.XPath("//li[text()='Two']")).Click();
            Thread.Sleep(1500);

            Driver.FindElement(By.XPath("//li[text()='Eight']")).Click();
            Thread.Sleep(1500);

            Driver.FindElement(By.XPath("//li[text()='Three']")).Click();
            Thread.Sleep(1500);
        }
    }
}
