using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace _9.Dynamic_properties
{
    internal class Program
    {
        public static object Assert { get; private set; }

        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.Navigate().GoToUrl("https://demoqa.com/dynamic-properties");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            dynamic_prop(driver);

            Console.Write("Test Case Closed:");

            Task.Delay(120000).Wait();

            driver.Close();
            driver.Quit();
        }

        static void dynamic_prop(IWebDriver driver)
        {
            IWebElement enableAfter5 = driver.FindElement(By.Id("enableAfter"));
            IWebElement coloredButton = driver.FindElement(By.Id("colorChange"));
            ReadOnlyCollection<IWebElement> visibleAfter5 = driver.FindElements(By.Id("visibleAfter"));

            string initialButtonColor = coloredButton.GetCssValue("color");

            Assert.IsFalse(enableAfter5.Enabled);
            Assert.IsTrue(visibleAfter5.Count == 0);

            Thread.Sleep(5100);

            ReadOnlyCollection<IWebElement> visibleAfter5_ = driver.FindElements(By.Id("visibleAfter"));

            Assert.IsTrue(enableAfter5.Enabled);
            Assert.IsTrue(visibleAfter5_.Count > 0);
            Assert.AreNotEqual(initialButtonColor, coloredButton.GetCssValue("color"));

            Console.WriteLine("Checks Successful!");

            Thread.Sleep(3000);

            driver.Quit();
        }
    }
}
