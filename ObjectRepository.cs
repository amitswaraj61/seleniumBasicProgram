using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Configuration;


namespace SeleniumBasicProgram
{
    class ObjectRepository
    {
        IWebDriver driver = new ChromeDriver();



        [Test]
        public void ReadConfigurationTest()
        {
            driver.Url= ConfigurationManager.AppSettings["URL"];
            driver.Manage().Window.Maximize();
            driver.Quit();
        }

    }
}
