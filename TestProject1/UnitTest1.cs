using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TestProject1.PageObjectModel;

namespace TestProject1
{
    //initialising our driver in DriverHelper class
    public class Tests : DriverHelper
    {
        
    
        [SetUp]
        public void Setup()
        {
           driver = new ChromeDriver();
            
        }

        [Test]
        public void Test1()
        {
            
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            CustomControl.SelectByText(driver.FindElement(By.Id("ContentPlaceHolder1_Add1-awed")), "Cauliflower");
            CustomControl.SelectByValue(driver.FindElement(By.Id("ContentPlaceHolder1_Add1-awed")), "187");



        }

        [Test] 
        public void LogInTest() 
        
        {
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            driver.Manage().Window.Maximize();
            HomePage homePage = new HomePage();
            LogInPage logInPage = new LogInPage();

            homePage.ClickLogin();

            logInPage.EnterUsernameAndPassword("admin", "password");
            logInPage.EnterPasConfirmLog_In();
            Assert.That(homePage.IsLogOffExist(),Is.True, "Log off button not displayed");
            homePage.ClockLogOff();

            

        }


    }
}