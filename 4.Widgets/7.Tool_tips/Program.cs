using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _7.Tool_tips
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/tool-tips");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            tool_tips(driver);
            Thread.Sleep(2000);

            Thread.Sleep(20000);

            Console.Write("Test Case Closed:");
        }

        static void tool_tips(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("window.scrollBy(0,150)");
            Thread.Sleep(1500);

            IWebElement hover_on_BTN = driver.FindElement(By.XPath("//button[@id='toolTipButton']"));
            IWebElement hover_on_text_field = driver.FindElement(By.XPath("//input[@id='toolTipTextField']"));
            IWebElement hover_on_contrary = driver.FindElement(By.XPath("//a[normalize-space()='Contrary']"));
            IWebElement hover_on_link2 = driver.FindElement(By.XPath("//a[normalize-space()='1.10.32']"));

            Actions actions1 = new Actions(driver);
            actions1.MoveToElement(hover_on_BTN).Perform();
            Thread.Sleep(2000);

            Actions actions2 = new Actions(driver);
            actions2.MoveToElement(hover_on_text_field).Perform();
            Thread.Sleep(2000);

            Actions actions3 = new Actions(driver);
            actions3.MoveToElement(hover_on_contrary).Perform();
            Thread.Sleep(2000);

            Actions actions4 = new Actions(driver);
            actions4.MoveToElement(hover_on_link2).Perform();
            Thread.Sleep(2000);
        }  
    }
}
