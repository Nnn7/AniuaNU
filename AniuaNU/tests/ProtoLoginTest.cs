using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AniuaNU
{
    class ProtoLoginTest
    {
        [Test]
        [Description("Test of logining")]
            

        public void Test1()
        {
            String UserName = Environment.GetEnvironmentVariable("ANUALogin");
            String UserPassword = Environment.GetEnvironmentVariable("ANUAPassword");
            String baseurl = "http://aniua.com/";
            String expected_result = "Вихід";
            String result;

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(baseurl);
          
            driver.FindElement(By.Name("username")).SendKeys(UserName);
            driver.FindElement(By.Name("password")).SendKeys(UserPassword);
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();

            result = driver.FindElement(By.CssSelector("a[href='logout.php']")).Text;

            Assert.AreEqual(result, expected_result);

            driver.FindElement(By.CssSelector("a[href='logout.php']")).Click();

            driver.Close();
        }

       

    }
}
