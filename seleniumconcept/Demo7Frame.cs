using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace seleniumconcept
{
    class Demo7Frame
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

           driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";

            //click on go



        }
    }
}
