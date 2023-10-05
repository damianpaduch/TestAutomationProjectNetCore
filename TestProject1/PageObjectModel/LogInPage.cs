using OpenQA.Selenium;


namespace TestProject1.PageObjectModel
{
    public class LogInPage : DriverHelper
    {
        IWebElement UserName => driver.FindElement(By.Id("UserName"));
        IWebElement UserPassword => driver.FindElement(By.Id("Password"));
        IWebElement SelectLog_In => driver.FindElement(By.CssSelector("#loginForm > form > div:nth-child(5) > div > input"));
        
        public void EnterUsernameAndPassword(string userName, string password)
        {

            UserName.SendKeys(userName);
            UserPassword.SendKeys(password);
        }
        public void EnterPasConfirmLog_In()
        {
            SelectLog_In.Click();
        }


    }
}
