using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1.Text_box
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Driver.Navigate().GoToUrl("https://demoqa.com/text-box");

            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            TextBox(Driver);

            Console.Write("Test Case Closed:");

            Task.Delay(120000).Wait();

            Driver.Close();
            Driver.Quit();


        }

        static void TextBox(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            string name = "Vidya Kumari";
            string email = "sharmavidya939@gmail.com";
            string cadd = "Durgapur, W.B.";
            string padd = "Dhanbad, Jharkhand";

            Driver.FindElement(By.Id("userName")).SendKeys(name);
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("userEmail")).SendKeys(email);
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("currentAddress")).SendKeys(cadd);
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("permanentAddress")).SendKeys(padd);
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(500);

            Driver.FindElement(By.Id("submit")).Click();

        }
    }
}

