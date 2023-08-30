using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace seleniumconcept
{
    class Demo5Tabs
    {
        public static void Main8(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.db4free.net/";

            //click on phpMyAdmin »

            driver.FindElement(By.PartialLinkText("phpMyAdmin")).Click();

            //switch to second tab

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.Id("input_username")).SendKeys("admin");


            driver.Close();// see which tab is closed
        }
    }
}
