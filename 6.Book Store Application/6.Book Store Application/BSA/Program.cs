using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace book_store_application
{
    internal class Program
    {
        private static string p;
        private static string c;

        static void Main(string[] args)
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Actions a = new Actions(Driver);

            //Driver.Navigate().GoToUrl("https://demoqa.com/books");
            Driver.Navigate().GoToUrl("https://demoqa.com/login");

            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            //login(Driver);
            //Thread.Sleep(2000);

            login_page(Driver);
            Thread.Sleep(2000);

            profile_page(Driver);
            Thread.Sleep(2000);
        }

        static void login(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            string fName = "Vidya";
            string lName = "Kumari";
            string userName = "vk007";
            string password = "12345";

            js.ExecuteScript("window.scrollBy(0,170)");
            Thread.Sleep(2000);

            IWebElement loginBTN = Driver.FindElement(By.XPath("//button[@id='login']"));
            loginBTN.Click();
            Thread.Sleep(1500);

            js.ExecuteScript("window.scrollBy(0,120)");
            Thread.Sleep(2000);

            IWebElement new_user_BTN = Driver.FindElement(By.XPath("//button[@id='newUser']"));
            new_user_BTN.Click();
            Thread.Sleep(1500);

            js.ExecuteScript("window.scrollBy(0,240)");
            Thread.Sleep(2000);

            //REGISTRATION---->

            IWebElement fname_BOX = Driver.FindElement(By.XPath("//input[@id='firstname']"));
            fname_BOX.Click();
            Thread.Sleep(100);
            fname_BOX.SendKeys(fName);
            Thread.Sleep(1000);

            IWebElement lname_BOX = Driver.FindElement(By.XPath("//input[@id='lastname']"));
            lname_BOX.Click();
            Thread.Sleep(100);
            lname_BOX.SendKeys(lName);
            Thread.Sleep(1000);

            IWebElement user_name_BOX = Driver.FindElement(By.XPath("//input[@id='userName']"));
            user_name_BOX.Click();
            Thread.Sleep(100);
            user_name_BOX.SendKeys(userName);
            Thread.Sleep(1000);

            IWebElement password_BOX = Driver.FindElement(By.XPath("//input[@id='password']"));
            password_BOX.Click();
            Thread.Sleep(100);
            password_BOX.SendKeys(password);
            Thread.Sleep(1000);

            //IWebElement captcha_BTN = Driver.FindElement(By.XPath("//div[@class='recaptcha-checkbox-border']"));
            //captcha_BTN.Click();
            //Thread.Sleep(1500);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement register_BTN = Driver.FindElement(By.XPath("//button[@id='register']"));
            register_BTN.Click();
            Thread.Sleep(1500);

            //Popup comes-> user registered successfully
            Driver.SwitchTo().Alert().Accept();

            //back to login page
            IWebElement back_to_login_BOX = Driver.FindElement(By.XPath("//button[@id='gotologin']"));
            back_to_login_BOX.Click();
            Thread.Sleep(2000);

        }

        static void login_page(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            string userName = "Abc12341234";
            string password = "Abc@1234";

            js.ExecuteScript("window.scrollBy(0,170)");
            Thread.Sleep(2000);

            IWebElement userNameBOX = Driver.FindElement(By.XPath("//input[@id='userName']"));
            userNameBOX.Click();
            Thread.Sleep(100);
            userNameBOX.SendKeys(userName);
            Thread.Sleep(1000);

            IWebElement passwordBOX = Driver.FindElement(By.XPath("//input[@id='password']"));
            passwordBOX.Click();
            Thread.Sleep(100);
            passwordBOX.SendKeys(password);
            Thread.Sleep(1000);

            IWebElement loginBTN = Driver.FindElement(By.XPath("//button[@id='login']"));
            loginBTN.Click();
            Thread.Sleep(1000);

            js.ExecuteScript("window.scrollBy(0,170)");
            Thread.Sleep(2000);
        }

        static void profile_page(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            string userName = "Abc12341234";
            string password = "Abc@1234";
            string searchText = "Javascript";

            js.ExecuteScript("window.scrollBy(0,250)");
            Thread.Sleep(2000);

            IWebElement goToBookStore_BTN = Driver.FindElement(By.XPath("//button[@id='gotoStore']"));
            goToBookStore_BTN.Click();
            Thread.Sleep(1500);

            js.ExecuteScript("window.scrollBy(0,100)");
            Thread.Sleep(2000);

            IWebElement searchBOX1 = Driver.FindElement(By.XPath("//input[@id='searchBox']"));
            searchBOX1.Click();
            Thread.Sleep(100);
            searchBOX1.SendKeys(searchText);
            Thread.Sleep(1000);
            //IWebElement searchBTN = Driver.FindElement(By.XPath("//*[@id='basic - addon2']"));
            //searchBTN.Click();
            //Thread.Sleep(1500);

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);

            //after searching, 4 results coming, now handle them----->
            IWebElement resultLink1 = Driver.FindElement(By.XPath("//a[normalize-space()='Learning JavaScript Design Patterns']"));
            resultLink1.Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);

            //Back command is used to navigate to the previous page in the browser history. This is exactly similar to what happens when you click on the back button in your browser.
            Driver.Navigate().Back();

            js.ExecuteScript("window.scrollBy(0,100)");
            Thread.Sleep(2000);

            IWebElement searchBOX2 = Driver.FindElement(By.XPath("//input[@placeholder='Type to search']"));
            searchBOX2.Click();
            Thread.Sleep(100);
            searchBOX2.SendKeys(searchText);
            Thread.Sleep(1000);

            IWebElement resultLink1st = Driver.FindElement(By.XPath("//a[normalize-space()='Learning JavaScript Design Patterns']"));

            //now again clicked on 1st result and test the "BACK TO BOOK STORE" button
            resultLink1st.Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);

            IWebElement backToBookStore_BTN = Driver.FindElement(By.XPath("//button[normalize-space()='Back To Book Store']"));
            backToBookStore_BTN.Click();
            Thread.Sleep(1000);

            //
            js.ExecuteScript("window.scrollBy(0,100)");
            Thread.Sleep(2000);

            IWebElement searchBOX3 = Driver.FindElement(By.XPath("//input[@placeholder='Type to search']"));
            searchBOX3.Click();
            Thread.Sleep(100);
            searchBOX3.SendKeys(searchText);
            Thread.Sleep(1000);

            IWebElement resultLink2nd = Driver.FindElement(By.XPath("//a[normalize-space()='Learning JavaScript Design Patterns']"));

            //now again clicked on 1st result and to test the link inside
            resultLink2nd.Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,400)");
            Thread.Sleep(2000);

            IWebElement ResultLink_inside1 = Driver.FindElement(By.XPath("//label[contains(text(),'http://www.addyosmani.com/resources/essentialjsdes')]"));
            ResultLink_inside1.Click();
            Thread.Sleep(5000);
            p = Driver.WindowHandles[0];
            c = Driver.WindowHandles[1];
            Driver.SwitchTo().Window(c);
            Driver.Close();
            Thread.Sleep(2000);
            Driver.SwitchTo().Window(p);

            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);

            //now test the "ADD TO COLLECTION" button
            IWebElement addCollection_BTN = Driver.FindElement(By.XPath("//button[normalize-space()='Add To Your Collection']"));
            addCollection_BTN.Click();
            Thread.Sleep(5000);

            //void accept() // To click on the ‘OK’ button of the alert.
            Driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);

            //now one book ["Learning JavaScript Design Patterns"] from search result is added in collection, now go back and select that book again and again add this in our collection.
            IWebElement backToBookStore_BTN2 = Driver.FindElement(By.XPath("//button[normalize-space()='Back To Book Store']"));
            backToBookStore_BTN2.Click();
            Thread.Sleep(1000);

            IWebElement searchBOX4 = Driver.FindElement(By.XPath("//input[@placeholder='Type to search']"));
            searchBOX4.Click();
            Thread.Sleep(100);
            searchBOX4.SendKeys(searchText);
            Thread.Sleep(1000);

            IWebElement resultLink3rd = Driver.FindElement(By.XPath("//a[normalize-space()='Learning JavaScript Design Patterns']"));

            //now again clicked on 1st result and again add this to our collection
            resultLink3rd.Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);

            IWebElement addCollection_BTN2 = Driver.FindElement(By.XPath("//button[normalize-space()='Add To Your Collection']"));
            addCollection_BTN2.Click();
            Thread.Sleep(2000);

            //Popup says:- book already in collection.
            //void accept() // To click on the ‘OK’ button of the alert.
            Driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);

            //now click on "back to book store" and add 3 more books
            IWebElement backToBookStore_BTN3 = Driver.FindElement(By.XPath("//button[normalize-space()='Back To Book Store']"));
            backToBookStore_BTN3.Click();
            Thread.Sleep(1000);

            IWebElement book1 = Driver.FindElement(By.XPath("//a[normalize-space()='Git Pocket Guide']"));
            IWebElement book2 = Driver.FindElement(By.XPath("//a[normalize-space()='Learning JavaScript Design Patterns']"));
            IWebElement book3 = Driver.FindElement(By.XPath("//a[normalize-space()='Designing Evolvable Web APIs with ASP.NET']"));
            IWebElement book4 = Driver.FindElement(By.XPath("//a[normalize-space()='Speaking JavaScript']"));
            IWebElement bookLast = Driver.FindElement(By.XPath("//a[normalize-space()='Understanding ECMAScript 6']"));

            //add 1st book
            js.ExecuteScript("window.scrollBy(0,150)");
            Thread.Sleep(2000);

            book1.Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);

            IWebElement addCollection_BTN3 = Driver.FindElement(By.XPath("//button[normalize-space()='Add To Your Collection']"));
            addCollection_BTN3.Click();
            Thread.Sleep(3000);

            Driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);

            IWebElement backToBookStore_BTN4 = Driver.FindElement(By.XPath("//button[normalize-space()='Back To Book Store']"));
            backToBookStore_BTN4.Click();
            Thread.Sleep(1000);



            //js.ExecuteScript("window.scrollBy(0,150)");
            //Thread.Sleep(2000);

            //book1.Click();
            //Thread.Sleep(2000);

            //js.ExecuteScript("window.scrollBy(0,500)");
            //Thread.Sleep(2000);

            //IWebElement addCollection_BTN3 = Driver.FindElement(By.XPath("//button[normalize-space()='Add To Your Collection']"));
            //addCollection_BTN3.Click();
            //Thread.Sleep(2000);

            //Driver.Navigate().Back();

        }
    }
}