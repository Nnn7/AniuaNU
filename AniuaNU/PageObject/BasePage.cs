using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniuaNU.PageObject
{
    public class BasePage
    {
        public String baseurl = "http://aniua.com/";

        public IWebDriver driver;
        public WebDriverWait Wait;
        private const int WaitTime = 30;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            //Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(WaitTime));
        }

        public void goToPage(String someUrl)
        {
            driver.Navigate().GoToUrl(someUrl);
        }

        public void goToHomePage()
        {
            driver.Navigate().GoToUrl(baseurl);
        }


    }
}
