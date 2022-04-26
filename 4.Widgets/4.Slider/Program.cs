using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4.Slider
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/slider");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            slider_by_mouse(driver);
            Thread.Sleep(2000);

            Thread.Sleep(20000);

            Console.Write("Test Case Closed:");
        }

        static void slider_by_mouse(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            IWebElement slider = driver.FindElement(By.XPath("//input[@type='range']"));
            Actions action = new Actions(driver);
            action.DragAndDropToOffset(slider, 1, 0).Perform();
            Thread.Sleep(500);
            action.DragAndDropToOffset(slider, 100, 0).Perform();
            Thread.Sleep(500);
            action.DragAndDropToOffset(slider, 25, 0).Perform();
            Thread.Sleep(500);
            action.DragAndDropToOffset(slider, 70, 0).Perform();
            Thread.Sleep(500);
            action.DragAndDropToOffset(slider, -25, 0).Perform();
        }
    }
}
