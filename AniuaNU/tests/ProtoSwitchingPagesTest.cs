using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AniuaNU
{
    class ProtoSwitchingPagesTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Description("")]
        public void Test1()
        {
            String UserName = Environment.GetEnvironmentVariable("ANUALogin");
            String UserPassword = Environment.GetEnvironmentVariable("ANUAPassword");
            String baseurl = "http://aniua.com/";
            //String expected_result = "Вихід";
            //String result;

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(baseurl);

            // new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementIsVisible((By.Name("username"))));
            driver.FindElement(By.Name("username")).SendKeys(UserName);
            driver.FindElement(By.Name("password")).SendKeys(UserPassword);
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();

            driver.FindElement(By.XPath("//a[@href='browse.php']")).Click();
            //as

            driver.FindElement(By.XPath("//a[@href='index.php']")).Click();
            //as

            driver.FindElement(By.XPath("//a[@href='http://forum.aniua.com/']")).Click();
            //as

            driver.FindElement(By.XPath("//a[@href='http://aniua.com/']")).Click();
            //as

            driver.FindElement(By.XPath("//a[@href='chat.php']")).Click();
            //as

            driver.FindElement(By.XPath("//a[@href='http://studio.aniua.com/']")).Click();
            //as

            driver.FindElement(By.XPath("//a[@href='http://aniua.com']")).Click();
            //as

            driver.FindElement(By.XPath("//a[@href='cooperation.php']")).Click();
            //as

            driver.FindElement(By.CssSelector("a[href='logout.php']")).Click();

            driver.Close();
        }


    }
}
