using BeymenUITest.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeymenUITest.Page
{
    public class CartPage : BasePage
    {
        public CartPage(IWebDriver driver): base(driver)
        {
                
        }
        public HomePage GoHome()
        {
            Click(By.ClassName("o-header__logo--img"));
            return new HomePage(_driver);
        }
        public string Prize()
        {
            return GetAttribute(By.ClassName("m-productPrice__salePrice"), "textContent");
        }
        public CartPage AddMore()
        {
            Click(By.XPath("//*[@id='quantitySelect0']/option[2]"));
        
            return this;

        }
        public CartPage Delete()
        {
            Click(By.Id("removeCartItemBtn0"));
            return this;

        }
    }
}
