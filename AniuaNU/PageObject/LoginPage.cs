using OpenQA.Selenium;
//using static AniuaNU.locators.LoginedPageLocators;

namespace AniuaNU.PageObject
{
    class LoginPage : BasePage
    {
        //private readonly By LogOutAnchor = AniuaNU.locators.LoginedPageLocators.

        

        public LoginPage(IWebDriver driver) : base(driver) 
        {
            this.driver = driver;            
        }

        public LoginPage goToHomePage()
        {
            driver.Navigate().GoToUrl(baseurl);
            return new LoginPage(driver);
        }

        public LoginedPage Login(string LoginName, string LoginPassword)
        {
            driver.FindElement(By.Name("username")).SendKeys(LoginName);
            driver.FindElement(By.Name("password")).SendKeys(LoginPassword);
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            return new LoginedPage(driver);
        }

        /*
        public void TestOfLogin()
        {
            driver.FindElement(By.CssSelector("a[href='logout.php']"));
            
        }
        */
    }
}
