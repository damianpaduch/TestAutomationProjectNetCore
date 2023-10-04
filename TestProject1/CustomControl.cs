using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
