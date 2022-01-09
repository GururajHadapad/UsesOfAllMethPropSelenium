using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Collections.ObjectModel;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.IE;

namespace SeleniumBasic.DataProvider
{
     class CrossBrowserTesting
    {

        //******************** InterNet Explorer Browser *****************//

        //[Test]
        //public void openInternetExplorerBrowser()
        //{ 
        //    IWebDriver driver = new InternetExplorerDriver();
        //    driver.Url = "https://www.facebook.com/";
        //    string title = driver.Title;
        //   Console.WriteLine(title);
        //    driver.Quit(); 
        //}

        //********************** FireFox Browser ******************//

        //[Test]
        //public void openFireFoxBrowser()
        //{
        //    IWebDriver driver = new FirefoxDriver();
        //    driver.Url = "https://www.facebook.com/";
        //    string title = driver.Title;
        //    Console.WriteLine(title);
        //    driver.Quit();
        //}

        //[Test]
        //public void openFireFoxBrowser()
        //{
        //   FirefoxOptions options=new FirefoxOptions();
        //    options.AddArgument("--headless");
        //    IWebDriver driver = new FirefoxDriver(options);
        //    driver.Url = "https://www.facebook.com/";
        //    string title = driver.Title;
        //    Console.WriteLine(title);
        //    driver.Quit();
        //}

        //[Test]
        //public void openChromeBrowser()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Url = "https://www.facebook.com/";
        //    string title = driver.Title;
        //    Console.WriteLine(title);
        //    driver.Quit();  
        //}


        //********************** Chrome Browser ******************//


        //[Test]
        //public void openChromeBrowser()
        //{
        //    //This used to run chrome in headless mode

        //  ChromeOptions  options=new ChromeOptions();
        //    options.AddArgument("--headless");
        //    IWebDriver driver = new ChromeDriver(options);
        //    driver.Url = "https://www.facebook.com/";
        //    string title = driver.Title;
        //    Console.WriteLine(title);
        //    driver.Quit();
        //}

    }
}
