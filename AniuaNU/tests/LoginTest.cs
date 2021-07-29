using AniuaNU.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AniuaNU.tests
{
    class LoginTest : BaseTest
    {
        [Test]
        [Description("Test of logining")]


        public void TryLoginTest()
        {            
            String UserName = Environment.GetEnvironmentVariable("ANUALogin");
            String UserPassword = Environment.GetEnvironmentVariable("ANUAPassword");            
            IWebDriver  driver = initDriver();
            bool result;

            LoginPage page = new LoginPage(driver);

            result = page.goToHomePage().Login(UserName, UserPassword).FindLogOut();

            Assert.AreEqual(true, result);
            //
        }



}
}
