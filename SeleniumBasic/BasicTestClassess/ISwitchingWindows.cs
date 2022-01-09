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
     class ISwitchingWindows
    {
        //[Test]
        //public void parentWindowID()
        //{
        //    //Program to print id of opened parent window 
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("https://www.hyrtutorials.com/p/window-handles-practice.html");
        //   driver.FindElement(By.XPath("//button[@id='newWindowsBtn']")).Click();
        //    string parentwindow = driver.CurrentWindowHandle;           
        //    Console.WriteLine(parentwindow);
        //}

        //[Test]
        //public void IDOfAllWindow()
        //{
        //    //Program to print id of opened parent window 
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("https://www.hyrtutorials.com/p/window-handles-practice.html");
        //    driver.FindElement(By.XPath("//button[@id='newWindowsBtn']")).Click();
        //    ReadOnlyCollection<string> AllWindow = driver.WindowHandles;
        //    int numOfWindows = AllWindow.Count;
        //    foreach (string window in AllWindow)
        //    {
        //        Console.WriteLine(window);

        //    }
        //    driver.Quit();
        //}
        //[Test]
        //public void titleOfAllWindow()
        //{
        //    //Program to print title of all windows opened
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("https://www.hyrtutorials.com/p/window-handles-practice.html");
        //    driver.FindElement(By.XPath("//button[@id='newWindowsBtn']")).Click();
        //    ReadOnlyCollection<string> AllWindow = driver.WindowHandles;
        //    int numOfWindows = AllWindow.Count;
        //    foreach (string window in AllWindow)
        //    {
        //        Console.WriteLine(window);
        //        driver.SwitchTo().Window(window);
        //        string title = driver.Title;
        //        Console.WriteLine(title);
        //    }
        //    driver.Quit();
        //}

        //[Test]
        //public void titleOfAllWindow()
        //{
        //    //Program to print title close all windows opened one by one
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("https://www.hyrtutorials.com/p/window-handles-practice.html");
        //    driver.FindElement(By.XPath("//button[@id='newWindowsBtn']")).Click();
        //    ReadOnlyCollection<string> AllWindow = driver.WindowHandles;
        //    int numOfWindows = AllWindow.Count;
        //    foreach (string window in AllWindow)
        //    {
        //        Console.WriteLine(window);
        //        driver.SwitchTo().Window(window);
        //        string title = driver.Title;
        //        Console.WriteLine(title);
        //        driver.Close();  
        //    }          
        //}

        //[Test]
        //public void titleOfAllWindow()
        //{
        //    //Program to close all window except parent window
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("https://www.hyrtutorials.com/p/window-handles-practice.html");
        //    string parentwindow = driver.CurrentWindowHandle;
        //    driver.FindElement(By.XPath("//button[@id='newWindowsBtn']")).Click();
        //    ReadOnlyCollection<string> AllWindow = driver.WindowHandles;
        //    int numOfWindows = AllWindow.Count;
        //    foreach (string window in AllWindow)
        //    {
        //        Console.WriteLine(window);
        //        driver.SwitchTo().Window(window);
        //        if(window != parentwindow)
        //        {
        //            driver.Close();
        //        }              
        //    }
        //}

        [Test]
        public void titleOfAllWindow()
        {
            //Program to close only parent window
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.hyrtutorials.com/p/window-handles-practice.html");
            driver.FindElement(By.XPath("//button[@id='newWindowsBtn']")).Click();
           driver.Close();
        }


       //*************************** Assignment **********************//
       // program to close only parent window using its title//
       //Program to close only one child window using its title//



    }
}
