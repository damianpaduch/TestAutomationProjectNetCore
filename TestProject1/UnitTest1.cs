using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace TestProject1
{
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
            driver.FindElement(By.Id("ContentPlaceHolder1_AllMeals-awed")).Click();
            driver.FindElement(By.CssSelector("#ContentPlaceHolder1_AllMeals-dropmenu > div.o-srcc.o-ldngp > input")).SendKeys("Tomato");
            driver.FindElement(By.CssSelector("#ContentPlaceHolder1_AllMeals-dropmenu > div.o-itsc")).Click();

            CustomControl control = new CustomControl();
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo-awed", "#ContentPlaceHolder1_AllMealsCombo-dropmenu > div.o-itsc > ul > li");
           
            
        }
    }
}