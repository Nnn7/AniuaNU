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
            //  IWebDriver driver = new ChromeDriver();

            IWebDriver  driver = initDriver();

            LoginPage loginPage = new LoginPage(driver);

            loginPage.goToHomePage();

            loginPage.Login(UserName, UserPassword);
            
                 

           
            
        }



}
}
