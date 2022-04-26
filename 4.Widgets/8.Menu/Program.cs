using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _8.Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/menu#");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            menu(driver);
            Thread.Sleep(2000);

            Thread.Sleep(20000);

            Console.Write("Test Case Closed:");
        }

        static void menu(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("window.scrollBy(0,150)");
            Thread.Sleep(1500);

            IWebElement menu_item_1 = driver.FindElement(By.XPath("//a[normalize-space()='Main Item 1']"));
            IWebElement menu_item_2 = driver.FindElement(By.XPath("//a[normalize-space()='Main Item 2']"));
            IWebElement menu_item_3 = driver.FindElement(By.XPath("//a[normalize-space()='Main Item 3']"));
            IWebElement sub_sub_list = driver.FindElement(By.XPath("//a[normalize-space()='SUB SUB LIST »']"));
            IWebElement sub_sub_item1 = driver.FindElement(By.XPath("//a[normalize-space()='Sub Sub Item 1']"));
            IWebElement sub_sub_item2 = driver.FindElement(By.XPath("//a[normalize-space()='Sub Sub Item 2']"));

            Actions actions1 = new Actions(driver);
            actions1.MoveToElement(menu_item_1).Perform();
            Thread.Sleep(1500);

            Actions actions2 = new Actions(driver);
            actions2.MoveToElement(menu_item_2).Perform();
            Thread.Sleep(1500);

            Actions actions3 = new Actions(driver);
            actions3.MoveToElement(sub_sub_list).Perform();
            Thread.Sleep(1500);

            Actions actions4 = new Actions(driver);
            actions4.MoveToElement(sub_sub_item1).Perform();
            Thread.Sleep(1500);

            Actions actions5 = new Actions(driver);
            actions4.MoveToElement(sub_sub_item2).Perform();
            Thread.Sleep(1500);

            Actions actions6 = new Actions(driver);
            actions4.MoveToElement(menu_item_3).Perform();
            Thread.Sleep(1500);
        }
    }
}
