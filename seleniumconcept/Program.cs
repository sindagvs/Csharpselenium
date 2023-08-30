using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace seleniumconcept
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            // IWebDriver driver = new EdgeDriver();
            driver.Url = "https://www.facebook.com/";
            //driver.FindElement(By.Id("email")).SendKeys("john12345@gmail.com");
            //driver.FindElement(By.Id("pass")).SendKeys("welcome123");
            driver.FindElement(By.LinkText("Create new account")).Click();

            driver.FindElement(By.Name("firstname")).SendKeys("John");
            //enter lastname as wick

            driver.FindElement(By.Name("lastname")).SendKeys("wick");

            //enter password as welcome123.

            driver.FindElement(By.Id("password_step_input")).SendKeys("welcome123");

            //click on custom radi button

            driver.FindElement(By.XPath("//input[@value='-1']"));

            //20 Dec 2000

            SelectElement selectDay = new SelectElement(driver.FindElement(By.Id("day")));
            selectDay.SelectByText("20");


            SelectElement selectMonth = new SelectElement(driver.FindElement(By.Id("month")));
            selectDay.SelectByText("20");




        }
    }
}
