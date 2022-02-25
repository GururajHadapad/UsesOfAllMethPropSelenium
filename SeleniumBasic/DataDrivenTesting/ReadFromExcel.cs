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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NPOI.XSSF.UserModel;
using System.IO;

namespace SeleniumBasic.DataDrivenTesting
{
    [TestFixture]
    class ReadFromExcel
    {
       
        [Test]
        public void excel()
        {

            string path = @"C:\Users\Hp\Desktop\exceldata.xlsx";

            XSSFWorkbook workbook = new XSSFWorkbook(File.OpenRead(path));

         string  value= workbook.GetSheet("Sheet1").GetRow(1).GetCell(0).ToString();
            Console.WriteLine(value);
        }
    }
}
