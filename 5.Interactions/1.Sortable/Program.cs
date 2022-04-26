using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1.Sortable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/sortable");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            list(driver);
            Thread.Sleep(2000);

            grid(driver);
            Thread.Sleep(2000);

            Thread.Sleep(20000);

            Console.Write("Test Case Closed:");
        }

        static void list(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);

            WebElement d6 = (WebElement)Driver.FindElement(By.XPath("//div[@class='vertical-list-container mt-4']//div[text()='Six']"));

            WebElement d5 = (WebElement)Driver.FindElement(By.XPath("//div[@class='vertical-list-container mt-4']//div[text()='Five']"));

            WebElement d4 = (WebElement)Driver.FindElement(By.XPath("//div[@class='vertical-list-container mt-4']//div[text()='Four']"));

            WebElement d3 = (WebElement)Driver.FindElement(By.XPath("//div[@class='vertical-list-container mt-4']//div[text()='Three']"));

            WebElement d2 = (WebElement)Driver.FindElement(By.XPath("//div[@class='vertical-list-container mt-4']//div[text()='Two']"));

            WebElement d1 = (WebElement)Driver.FindElement(By.XPath("//div[@class='vertical-list-container mt-4']//div[text()='One']"));

            
            Actions action1 = new Actions(Driver);
            action1.DragAndDrop(d3, d5).Build().Perform();
            Thread.Sleep(2000);

            Actions action2 = new Actions(Driver);
            action2.DragAndDrop(d2, d6).Build().Perform();
            Thread.Sleep(1500);

            Actions action3 = new Actions(Driver);
            action3.DragAndDrop(d4, d2).Build().Perform();
            Thread.Sleep(1500);

            Actions action4 = new Actions(Driver);
            action4.DragAndDrop(d6, d1).Build().Perform();
            Thread.Sleep(1500);

            Actions action5 = new Actions(Driver);
            action5.DragAndDrop(d1, d4).Build().Perform();
            Thread.Sleep(1500);

            Actions action6 = new Actions(Driver);
            action6.DragAndDrop(d5, d3).Build().Perform();
            Thread.Sleep(1500);

        }

        static void grid(IWebDriver Driver)
        {

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//a[@id='demo-tab-grid']")).Click();
            Thread.Sleep(2000);

            WebElement d9 = (WebElement)Driver.FindElement(By.XPath("//div[@class='create-grid']//div[text()='Nine']"));

            WebElement d8 = (WebElement)Driver.FindElement(By.XPath("//div[@class='create-grid']//div[text()='Eight']"));

            WebElement d7 = (WebElement)Driver.FindElement(By.XPath("//div[@class='create-grid']//div[text()='Seven']"));

            WebElement d6 = (WebElement)Driver.FindElement(By.XPath("//div[@class='create-grid']//div[text()='Six']"));

            WebElement d5 = (WebElement)Driver.FindElement(By.XPath("//div[@class='create-grid']//div[text()='Five']"));

            WebElement d4 = (WebElement)Driver.FindElement(By.XPath("//div[@class='create-grid']//div[text()='Four']"));

            WebElement d3 = (WebElement)Driver.FindElement(By.XPath("//div[@class='create-grid']//div[text()='Three']"));

            WebElement d2 = (WebElement)Driver.FindElement(By.XPath("//div[@class='create-grid']//div[text()='Two']"));

            WebElement d1 = (WebElement)Driver.FindElement(By.XPath("//div[@class='create-grid']//div[text()='One']"));

            Actions action1 = new Actions(Driver);
            action1.DragAndDrop(d8, d6).Build().Perform();
            Thread.Sleep(1500);

            Actions action2 = new Actions(Driver);
            action2.DragAndDrop(d3, d5).Build().Perform();
            Thread.Sleep(1500);

            Actions action3 = new Actions(Driver);
            action3.DragAndDrop(d1, d4).Build().Perform();
            Thread.Sleep(1500);

            Actions action4 = new Actions(Driver);
            action4.DragAndDrop(d5, d8).Build().Perform();
            Thread.Sleep(1500);

            Actions action5 = new Actions(Driver);
            action5.DragAndDrop(d7, d2).Build().Perform();
            Thread.Sleep(1500);

            Actions action6 = new Actions(Driver);
            action6.DragAndDrop(d6, d3).Build().Perform();
            Thread.Sleep(1500);

            Actions action7 = new Actions(Driver);
            action7.DragAndDrop(d4, d7).Build().Perform();
            Thread.Sleep(1500);

            Actions action8 = new Actions(Driver);
            action8.DragAndDrop(d2, d9).Build().Perform();
            Thread.Sleep(1500);

            Actions action9 = new Actions(Driver);
            action9.DragAndDrop(d9, d1).Build().Perform();
            Thread.Sleep(1500);
        }
    }
}
