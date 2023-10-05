using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace TestProject1
{
    public class CustomControl : DriverHelper
    {

        public static void ComboBox (string controlName, string value)
        {
            IWebElement comboControl = driver.FindElement(By.Id($"{controlName}"));

            comboControl.Clear();
            comboControl.SendKeys("Apple");
            
            driver.FindElement(By.CssSelector($"{value}")).Click();
        }

        public static void EnterText(IWebElement webElement, string value) => webElement.SendKeys(value);

        public static void Click(IWebElement webElement) => webElement.Click();

        public static void SelectByValue(IWebElement webElement, string value)
        {
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByValue(value);
        }

        public static void SelectByText(IWebElement webElement, string text)
        {
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByText(text);
        }


    }
}
