using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automation_practice_form
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            String firstName = "Vidya";
            String lastName = "Kumari";
            String Email = "sharmavidya939@gmail.com";
            string phoneNo = "9198467765";
            string Dob = "28 May 2022";
            string sub1 = "mat";
            string cadd = "Durgapur, West Bengal - 713212";

            IWebDriver driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            IWebElement fNameBTN = driver.FindElement(By.XPath("//input[@id='firstName']"));
            fNameBTN.Click();
            fNameBTN.SendKeys(firstName);
            Thread.Sleep(1000);

            IWebElement lNameBTN = driver.FindElement(By.XPath("//input[@id='lastName']"));
            lNameBTN.Click();
            lNameBTN.SendKeys(lastName);
            Thread.Sleep(1000);

            IWebElement emailBTN = driver.FindElement(By.XPath("//input[@id='userEmail']"));
            emailBTN.Click();
            emailBTN.SendKeys(Email);
            Thread.Sleep(1000);


            IWebElement genderBTN = driver.FindElement(By.XPath("//label[normalize-space()='Female']"));
            genderBTN.Click();
            Thread.Sleep(1000);

            IWebElement phoneBTN = driver.FindElement(By.XPath("//input[@id='userNumber']"));
            phoneBTN.Click();
            phoneBTN.SendKeys(phoneNo);
            Thread.Sleep(1000);

            IWebElement dobBTN = driver.FindElement(By.XPath("//input[@id='dateOfBirthInput']"));
            dobBTN.Click();
            //driver.FindElement(By.XPath("//select[@class='react-datepicker__month-select']")).Click();
            //driver.FindElement(By.XPath("//*[text()='June']")).Click();
            //driver.FindElement(By.XPath("//option[@value='5']")).Click();
            driver.FindElement(By.XPath("//button[normalize-space()='Next Month']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[normalize-space()='Next Month']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//select[@class='react-datepicker__year-select']")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//select[@class='react-datepicker__year-select']")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[text()='2000']")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[text()='29']")).Click();

            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(2000);


            //IWebElement subBTN = driver.FindElement(By.XPath("//div[@class='subjects-auto-complete__input']"));
            //subBTN.Click();
            //Thread.Sleep(500);
            //subBTN.SendKeys(sub1);
            //Thread.Sleep(1000);

            IWebElement hobbies1 = driver.FindElement(By.XPath("//label[normalize-space()='Sports']"));
            hobbies1.Click();
            Thread.Sleep(500);
            hobbies1.Click();
            Thread.Sleep(500);

            IWebElement hobbies2 = driver.FindElement(By.XPath("//label[normalize-space()='Reading']"));
            hobbies2.Click();
            Thread.Sleep(500);
            hobbies2.Click();
            Thread.Sleep(500);

            IWebElement hobbies3 = driver.FindElement(By.XPath("//label[normalize-space()='Music']"));
            hobbies3.Click();
            Thread.Sleep(500);
            hobbies3.Click();
            Thread.Sleep(500);

            hobbies1.Click();
            Thread.Sleep(500);
            hobbies2.Click();
            Thread.Sleep(500);
            hobbies3.Click();
            Thread.Sleep(500);

            IWebElement picture = driver.FindElement(By.Id("uploadPicture")); 
            picture.SendKeys(@"C:\Users\HP\Desktop\sampleFile.jpeg");
            Thread.Sleep(1000);

            IWebElement addressBTN = driver.FindElement(By.XPath("//textarea[@id='currentAddress']"));
            addressBTN.Click();
            addressBTN.SendKeys(cadd);
            Thread.Sleep(1000);


            Thread.Sleep(2000);

            Console.Write("Test Case Closed:");
        }
    }
}
