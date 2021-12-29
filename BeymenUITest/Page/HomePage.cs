using BeymenUITest.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using BeymenUITest.Constant;

namespace BeymenUITest.Page
{
    public class HomePage: BasePage
    {
        public HomePage(IWebDriver driver): base(driver)
        {
      
        }
      
        public HomePage GoHome()
        {
            String link = @"https://www.beymen.com/";
            _wait.Until(f => f.Navigate());
            _driver.Navigate().GoToUrl(link);
            return this;
           
        }
        public CustomerLoginPage ClickLogin()
        {
            Click(By.ClassName("bwi-account-o"));
            return new CustomerLoginPage(_driver);
        }
        public FavoritePage ClickFavorite()
        {
            Click(By.ClassName("bwi-favorite-o"));
            return new FavoritePage(_driver);
        }
        public CartPage ClickCart()
        {
            Click(By.ClassName("bwi-cart-o"));
            return new CartPage(_driver);
        }
        public SearchPage SearchProduct(string key)
        {
            
            SendKey(HomeConstant.SearchArea, key);
            Click(By.ClassName("bmi-search"));
            return new SearchPage(_driver);

        }
        public bool IsCartEmpty()
        {
            try
            {
                IWebElement element = FindElement(By.ClassName("o-header__userInfo--count"));
                return false;
            }
            catch
            {
                return true;
            }

        }
    }
}
