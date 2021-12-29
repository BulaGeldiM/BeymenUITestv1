using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeymenUITest.Base
{
    public abstract class BasePage
    {
        protected WebDriverWait _wait;
        protected IWebDriver _driver;
        
        public BasePage(IWebDriver driver)
        {
            this._driver = driver;
            this._wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

        }
        public IWebElement FindElement(By by)
        {
         return _wait.Until(f => f.FindElement(by));
            //return _driver.FindElement(by);
        }
        public void Click(By by)
        {
            FindElement(by).Click();   
        }
        public void SendKey(By by,string key)
        {
            FindElement(by).SendKeys(key);
        }
        public string GetAttribute(By by, string attributeName)
        {
            return FindElement(by).GetAttribute(attributeName);
        }
    }
}
