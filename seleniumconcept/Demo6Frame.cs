using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace seleniumconcept
{
    public class Demo6Frame
    {
        public static void Main9(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='login_page']")));
            //enter userid as john123

            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("jack123");
            //click on continue

            driver.FindElement(By.LinkText("CONTINUE")).Click();


            //switch to main html
            driver.SwitchTo().DefaultContent();



            //enter userid as john123
        }
    }
}
