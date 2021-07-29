using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AniuaNU.PageObject
{
    class LoginPage : BasePage
    {
        //public IWebDriver driver;
        public LoginPage(IWebDriver driver) : base(driver) 
        {
            this.driver = driver;            
        }


        public void Login(string LoginName, string LoginPassword)
        {
            driver.FindElement(By.Name("username")).SendKeys(LoginName);
            driver.FindElement(By.Name("password")).SendKeys(LoginPassword);
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            //return new LoginedPage(driver);
        }


    }
}
