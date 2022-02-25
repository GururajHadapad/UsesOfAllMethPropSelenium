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

namespace SeleniumBasic.BaseClass
{
     class Override
    {
        [Test]
        public  virtual void job(string s)
        {
            
            
        }
    }

    class sub : Override
    {
        [Test]
        public override  void job(string s)
        {
            
        }

    }
}
