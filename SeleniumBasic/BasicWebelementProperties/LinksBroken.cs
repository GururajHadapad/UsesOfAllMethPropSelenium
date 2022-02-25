using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SeleniumBasic.BasicWebelementProperties
{
     class LinksBroken
    {
        [Test]
        public void links()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://www.google.co.in/maps/");
            HttpWebRequest req = null;
            var urls = webDriver.FindElements(By.XPath("//a"));
            Console.WriteLine(urls.Count());

            for (int i=0;i<urls.Count();i++)
            {
                var url = urls[i].GetAttribute("href");  
                Console.WriteLine(url);
            }

            //foreach (var url in urls)
            //{
            //    if (!(url.Text.Contains("Email") || url.Text == ""))
            //    {
            //        req = (HttpWebRequest)WebRequest.Create(url.GetAttribute("href"));
            //        try
            //        {
            //            var response = (HttpWebResponse)req.GetResponse();
            //            System.Console.WriteLine($"URL: {url.GetAttribute("href")} status is :{response.StatusCode}");
            //        }
            //        catch (WebException e)
            //        {
            //            var errorResponse = (HttpWebResponse)e.Response;
            //            System.Console.WriteLine($"URL: {url.GetAttribute("href")} status is :{errorResponse.StatusCode}");
            //        }
            //    }
            //}
            webDriver.Close();
        }
    }
}
