using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using SeleniumBasic.BaseClass;

namespace SeleniumBasic.BasicTestClassess
{
    [TestFixture]
     class AGetTitleUrlPageSource : LoggersClass
    {
        [Test]
        public void getTitle() 
        {
            Console.WriteLine(driver.Title);
        }
        [Test]
        public void getUrl()
        {
            Console.WriteLine(driver.Url);
        }
        [Test]
        public void getPageSource()
        {
            Console.WriteLine(driver.PageSource);
        }
       
    }
}
