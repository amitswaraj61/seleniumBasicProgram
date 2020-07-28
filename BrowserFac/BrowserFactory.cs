using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasicProgram.BrowserFac
{
   public class  BrowserFactory
    {
        IWebDriver driver;
        public  IWebDriver InitBrowser(string browser)
        {
            try
            {
                if (browser == null)
                {
                    throw new BrowserCustomException("Browser not be null", BrowserCustomException.ExceptionType.NULL_EXCEPTION);
                }
                if (browser.Length == 0)
                {
                    throw new BrowserCustomException("Browser not be empty", BrowserCustomException.ExceptionType.EMPTY_EXCEPTION);
                }
                switch (browser)
                {
                    case "chrome":
                        ChromeOptions chromeOptions = new ChromeOptions();
                        chromeOptions.AddArgument("--disable-notifications");
                        driver = new ChromeDriver(chromeOptions);
                        break;
                    case "firefox":
                        FirefoxOptions firefoxOptions = new FirefoxOptions();
                        firefoxOptions.SetPreference("dom.webnotifications.enabled", false);
                        driver = new FirefoxDriver(firefoxOptions);
                        break;
                }
                return driver;
            }
            catch (BrowserCustomException exception)
            {
                 throw new BrowserCustomException(exception.Message, BrowserCustomException.ExceptionType.NULL_EXCEPTION);
            }
         
        }
    }
}