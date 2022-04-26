using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _9.Select_menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/select-menu");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            selectMenu(driver);
            Thread.Sleep(2000);

            Thread.Sleep(20000);

            Console.Write("Test Case Closed:");
        }

        static void selectMenu(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("window.scrollBy(0,150)");
            Thread.Sleep(1500);

            //IWebElement value_dropDown = driver.FindElement(By.XPath("//div[contains(text(),'Select Option')]"));
            //value_dropDown.Click();
            //Thread.Sleep(1500);

            //SelectElement oSelect = new SelectElement(driver.FindElement(By.ClassName("//*[@id='withOptGroup']/div/div[1]/div[1]")));
            //oSelect.SelectByValue("Group 2, option 2");

            //Old Style Select Menu
            IWebElement oldMenu = driver.FindElement(By.Id("oldSelectMenu"));
            oldMenu.Click();
            Thread.Sleep(1500);

            driver.FindElement(By.XPath("//*[@id='oldSelectMenu']/option[4]")).Click();
            Thread.Sleep(1500);

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(1500);

            
            //Multiselect drop down
            IWebElement multiMenu = driver.FindElement(By.XPath("//div[contains(text(),'Select...')]"));
            multiMenu.Click();
            Thread.Sleep(1500);

            IWebElement selectGreen = driver.FindElement(By.XPath("//div[contains(text(),'Green')]"));
            selectGreen.Click();
            Thread.Sleep(1500);

            IWebElement selectBlue = driver.FindElement(By.XPath("//div[contains(text(),'Blue')]"));
            selectBlue.Click();
            Thread.Sleep(1500);

            IWebElement selectBlack = driver.FindElement(By.XPath("//div[contains(text(),'Black')]"));
            selectBlack.Click();
            Thread.Sleep(1500);

            IWebElement selectRed = driver.FindElement(By.XPath("//div[contains(text(),'Red')]"));
            selectRed.Click();
            Thread.Sleep(1500);
        }
    }
}
