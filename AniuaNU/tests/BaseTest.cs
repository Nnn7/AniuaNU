using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniuaNU.tests
{
    class BaseTest
    {
        //public IWebDriver driver;
        public IWebDriver initDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }


    }
}
