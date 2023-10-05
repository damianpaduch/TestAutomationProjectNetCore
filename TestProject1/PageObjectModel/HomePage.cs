using OpenQA.Selenium;


namespace TestProject1.PageObjectModel
{
     public class HomePage : DriverHelper
    {
        //Identifying our Home Page web elements
        IWebElement linkLogin => driver.FindElement(By.LinkText("Login"));
        IWebElement linkLogOut => driver.FindElement(By.LinkText("Log off"));

        //creating functions for our Home Page web elements
        public void ClickLogin() => linkLogin.Click();
        public void ClockLogOff()
        {
            linkLogOut.Click();
        }
        public bool IsLogOffExist() => linkLogOut.Displayed;




    }
}
