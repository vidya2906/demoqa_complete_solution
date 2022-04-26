using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4.Nested_frames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/nestedframes");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            nested_frames(driver);
            Thread.Sleep(2000);

            Thread.Sleep(20000);

            Console.Write("Test Case Closed:");
        }

        static void nested_frames(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(1500);

            Driver.FindElement(By.XPath("//span[text()='Nested Frames']")).Click();
            Thread.Sleep(1500);

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(1500);

            Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//iframe[@id='frame1']")));
            Thread.Sleep(1500);

            Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//iframe[@srcdoc='<p>Child Iframe</p>']")));
            Thread.Sleep(1500);

            Driver.SwitchTo().ParentFrame();
            Thread.Sleep(1500);
        }
    }
}
