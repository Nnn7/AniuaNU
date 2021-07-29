using OpenQA.Selenium;

namespace AniuaNU.locators
{
    class LoginedPageLocators
    {
        public readonly By LogOutAnchor = By.CssSelector("a[href='logout.php']");
        public static int num { get; set; } = 0;
    }
}
