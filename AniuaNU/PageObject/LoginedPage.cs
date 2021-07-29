using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniuaNU.PageObject
{
    class LoginedPage
    {
        protected IWebDriver driver;
        public LoginedPage(IWebDriver driver)
        {
            this.driver = driver;
        }

    }
}
