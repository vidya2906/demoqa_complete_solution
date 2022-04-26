using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _7.Broken_links_images
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.Navigate().GoToUrl("https://demoqa.com/broken");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            ReadOnlyCollection<IWebElement> ImgElement = driver.FindElements(By.TagName("img"));

            ValidateImage(js, ImgElement[2]);

            //Broken Image Index
            //ValidateImage(js, ImgElement[3]);

            IWebElement FirstUrl = driver.FindElement(By.XPath("//a[text()='Click Here for Valid Link']"));
            string FirstUrlHref = FirstUrl.GetAttribute("href");
            ValidateHttpLink(FirstUrlHref);

            ////Thread.Sleep(3000);
            js.ExecuteScript("window.scrollBy(0,400)");
            Thread.Sleep(2000);

            Console.Write("Test Case Closed:");

            Task.Delay(120000).Wait();

            driver.Close();
            driver.Quit();
        }

        static void ValidateImage(IJavaScriptExecutor js, IWebElement imgElement)
        {
            Boolean IsValid = (Boolean)(js.ExecuteScript("return arguments[0].complete" + "&& typeof arguments[0].naturalWidth != \"undefined\" " + "&& arguments[0].naturalWidth > 0", imgElement));

            if (IsValid)
            {
                System.Console.WriteLine("Valid Image");
            }
            else
            {
                System.Console.WriteLine("Invalid Image");
            }
        }

        static bool ValidateHttpLink(string url)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);

            request.AllowAutoRedirect = true;

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Console.WriteLine("\nResponse Status Code is OK and StatusDescription is: {0}", response.StatusDescription);
                    response.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
