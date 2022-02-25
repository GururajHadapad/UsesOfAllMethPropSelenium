using System;
using System.IO;
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


namespace SeleniumBasic.DataDrivenTesting
{
     class ReadDataFomTextFile
    {

        // Reading a Text file: The file class in C# defines two static methods to read a text file namely
        // File.ReadAllText() and File.ReadAllLines().

        //The File.ReadAllText() reads the entire file at once and returns a string.
        //We need to store this string in a variable and use it to display the contents onto the screen.
        //The File.ReadAllLines() reads a file one line at a time and returns that line in string format.
        //We need an array of strings to store each line. We display the contents of the file using the same string array.
        public void textFileData() 
        {
            StreamReader sr = new StreamReader(@"C:\Users\Hp\Desktop\readDoc.txt");

            string a =sr.ReadLine();
            string b = sr.ReadLine();
            string c = sr.ReadLine();

            IWebDriver driver=new ChromeDriver(); 
           
             driver.FindElement(By.Id("a")).SendKeys(a);
            driver.FindElement(By.Id("b")).SendKeys(b);
            driver.FindElement(By.Id("c")).SendKeys(c);

            driver.FindElement(By.Name("//submit")).Click();

          string output= Console.ReadLine();
           
        }
    }
}
