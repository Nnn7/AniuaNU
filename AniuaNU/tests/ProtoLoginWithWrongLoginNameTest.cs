using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AniuaNU
{
    public class ProtoLoginWithWrongLoginNameTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Description("Test of logining with wrong LoginName")]
        public void Test1()
        {
            String UserName = "Test";
            String UserPassword = Environment.GetEnvironmentVariable("ANUAPassword");
            String baseurl = "http://aniua.com/";
            String expected_result = "Помилка входу";
            String result;

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(baseurl);


            // new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementIsVisible((By.Name("username"))));
            driver.FindElement(By.Name("username")).SendKeys(UserName);
            driver.FindElement(By.Name("password")).SendKeys(UserPassword);
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();

            result = driver.FindElement(By.CssSelector(".error > b:nth-child(1)")).Text;

            Assert.AreEqual(result, expected_result);

           // driver.FindElement(By.CssSelector("a[href='logout.php']")).Click();

            driver.Close();
        }
    }
}