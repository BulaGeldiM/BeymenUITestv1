using BeymenUITest.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeymenUITest.Page
{
    public class ProductPage : BasePage
    {
        
        public ProductPage(IWebDriver driver): base(driver)
        {
                
        }
       
        public  HomePage GoHome()
        {
            Click(By.ClassName("o-header__logo--img"));
            return new HomePage(_driver);
        }
        public ProductPage SizeClick(int sizeIndex)
        {
            string xPath = string.Format(".//*[@id='sizes']/div/span[{0}]", sizeIndex);
            Click(By.XPath(xPath));
            return this;
        }
        public string Prize()
        {
         return GetAttribute(By.Id("priceNew"), "textContent");
         
        }
        public ProductPage AddCart()
        {
            Click(By.Id("addBasket"));
            return this;
        }
        public CartPage GoCart()
        {
            Click(By.ClassName("bwi-cart-o"));
            return new CartPage(_driver);
        }
    }
}
