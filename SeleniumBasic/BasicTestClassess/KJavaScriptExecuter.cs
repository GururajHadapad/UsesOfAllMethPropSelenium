using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SeleniumBasic.BasicTestClassess
{
     class KJavaScriptExecuter
    {
        //[Test]
        //public void createAlertPop()
        // This code is used to create alert popup using javascript executer
        //{
        // IWebDriver  driver= new ChromeDriver();
        //    driver.Navigate().GoToUrl("https://www.facebook.com/");
        //    IJavaScriptExecutor js = ((IJavaScriptExecutor)driver);
        //    js.ExecuteScript("alert('hello')");
        //    Thread.Sleep(1000); 
        //    driver.Quit();
        //}

        //[Test]
        //public void refreshPage()
        // This method is used to Refresh the page 
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("https://www.facebook.com/");
        //    IJavaScriptExecutor js = ((IJavaScriptExecutor)driver);
        //    Thread.Sleep(5000);
        //    js.ExecuteScript("history.go(0)");
        //    driver.Quit();
        //}

        //[Test]
        //public void getInnerText()
        // This method is used to get the inner text of page
        //{
        //    IWebDriver driver = new ChromeDriver();
        //driver.Navigate().GoToUrl("https://www.facebook.com/");
        //IJavaScriptExecutor js = ((IJavaScriptExecutor)driver);
        //    string text = js.ExecuteScript("return document.documentElement.innerText").ToString();
        //    Console.WriteLine(text);
        //    driver.Quit();
        //}

        //[Test]
        //public void getTitle()
        // This method is used to get the title
        //{
        //    IWebDriver driver = new ChromeDriver();
        //driver.Navigate().GoToUrl("https://www.facebook.com/");
        //IJavaScriptExecutor js = ((IJavaScriptExecutor)driver);
        //string title = js.ExecuteScript("return document.title").ToString();
        //Console.WriteLine(title);
        //    driver.Quit();
        //}

        //[Test]
        //public void getDomain()
        //// This method is used to get the domain
        //{
        //    IWebDriver driver = new ChromeDriver();
        //driver.Navigate().GoToUrl("https://www.facebook.com/");
        //IJavaScriptExecutor js = ((IJavaScriptExecutor)driver);
        //string domain = js.ExecuteScript("return document.domain").ToString();
        //Console.WriteLine(domain);
        //    driver.Quit();
        //}

        //[Test]
        //public void getURL()
        //// This method is used to get the url
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("https://www.facebook.com/");
        //    IJavaScriptExecutor js = ((IJavaScriptExecutor)driver);
        //    string url = js.ExecuteScript("return document.URL").ToString();
        //    Console.WriteLine(url);
        //    driver.Quit();
        //}

        //[Test]
        //public void scrollBar()
        //// This method is used to scrool the page
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("https://www.facebook.com/");
        //    IJavaScriptExecutor js = ((IJavaScriptExecutor)driver);
        //    //this is used to scroll the page untill where we want by giving specfic value
        //    js.ExecuteScript("window.scrollBy(0,100)");
        //    //This is used to scroll the page till bottom
        //   // js.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");
        //    Thread.Sleep(2000);
        //    js.ExecuteScript("window.scrollTo(0,0)");
        //    Thread.Sleep(3000);
        //    //************ ScrollBy method is used scroll from the point where the control is ***************//
        //    //************ ScrollTo method is used scroll from Top of the page whereever the control is ***************//
        //    driver.Quit();
        //}

        //[Test]
        //public void SwitchPage()
        //// This method is used switch from one page to another page
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("https://www.facebook.com/");
        //    IJavaScriptExecutor js = ((IJavaScriptExecutor)driver);
        //     js.ExecuteScript("window.location='https://www.instagram.com/'");
        //    driver.Quit();
        //}

        //[Test]
        //public void getHeightNWidth()
        //// This method is used Height and Width of the page
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("https://www.facebook.com/");
        //    IJavaScriptExecutor js = ((IJavaScriptExecutor)driver);
        //    //object height = js.ExecuteScript("return window.innerHeight;");
        //    //Console.WriteLine(height);
        //    //object width = js.ExecuteScript("return window.innerWidth;");
        //    //Console.WriteLine(width);

        //    string height = js.ExecuteScript("return window.innerHeight;").ToString();
        //    Console.WriteLine(height);
        //    string width = js.ExecuteScript("return window.innerWidth;").ToString();
        //    Console.WriteLine(width);
        //    driver.Quit();
        //}

        //[Test]
        //public void EnterTextToField()
        //// This method is used to enter the text into the text field
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("https://www.facebook.com/");
        //    IJavaScriptExecutor js = ((IJavaScriptExecutor)driver);
        //    js.ExecuteScript("document.getElementById('email').value='abc123@gmail.com';");
        //    Thread.Sleep(1000);
        //    driver.Quit();
        //}

        //[Test]
        //public void ReadTextFromTextField()
        //// This method is used to read the text from hidden text field or text field
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("https://www.facebook.com/");
        //    IJavaScriptExecutor js = ((IJavaScriptExecutor)driver);
        //    js.ExecuteScript("document.getElementById('email').value='abc123@gmail.com';");
        //    Thread.Sleep(1000); 
        //    // this line of code is used to get text from any text field and also it can be used to get text of hidden text field
        //    string readTextField = js.ExecuteScript(" return document.getElementById('email').value").ToString();
        //    Console.WriteLine(readTextField);
        //    driver.Quit();
        //}
    }
}
