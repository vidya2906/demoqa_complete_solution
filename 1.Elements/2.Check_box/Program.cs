using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2.Check_box
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Driver.Navigate().GoToUrl("https://demoqa.com/checkbox");

            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            checkBox(Driver);

            Console.Write("Test Case Closed:");

            Task.Delay(120000).Wait();

            Driver.Close();
            Driver.Quit();
        }

        static void checkBox(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            //expand all after clicked on + button
            Driver.FindElement(By.XPath("//button[@aria-label='Expand all']")).Click();
            Thread.Sleep(500);

            Driver.FindElement(By.XPath("//span[contains(@class,'rct-checkbox')]")).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.XPath("//span[contains(@class,'rct-checkbox')]")).Click();
            Thread.Sleep(500);

            //Driver.FindElement(By.XPath("//label[contains(@id,'tree-node-notes')]")).Click();   //could not get result

            Driver.FindElement(By.XPath("//label[@for='tree-node-notes']")).Click();
            Thread.Sleep(500);

            Driver.FindElement(By.XPath("//label[@for='tree-node-commands']")).Click();
            Thread.Sleep(500);

            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//label[@for='tree-node-react']")).Click();
            Thread.Sleep(500);

            Driver.FindElement(By.XPath("//label[@for='tree-node-angular']")).Click();
            Thread.Sleep(500);

            Driver.FindElement(By.XPath("//label[@for='tree-node-veu']")).Click();
            Thread.Sleep(500);

            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(1000);

            Driver.FindElement(By.XPath("//label[@for='tree-node-public']")).Click();
            Thread.Sleep(500);

            Driver.FindElement(By.XPath("//label[@for='tree-node-private']")).Click();
            Thread.Sleep(500);

            Driver.FindElement(By.XPath("//label[@for='tree-node-classified']")).Click();
            Thread.Sleep(500);

            Driver.FindElement(By.XPath("//label[@for='tree-node-general']")).Click();
            Thread.Sleep(500);

            Driver.FindElement(By.XPath("//label[@for='tree-node-wordFile']")).Click();
            Thread.Sleep(500);

            Driver.FindElement(By.XPath("//label[@for='tree-node-excelFile']")).Click();
            Thread.Sleep(500);

            Driver.FindElement(By.XPath("//button[@aria-label='Collapse all']")).Click();
            Thread.Sleep(1000);

            Driver.FindElement(By.XPath("//span[contains(@class,'rct-checkbox')]")).Click();




            //Driver.FindElement(By.XPath("//span[@class='rct-title'][2]")).Click();

            Thread.Sleep(120000);

            //Driver.FindElement(By.XPath("//span[contains(@class,'rct-checkbox')]")).Click();

        }
    }
}

