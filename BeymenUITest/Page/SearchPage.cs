using BeymenUITest.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeymenUITest.Page
{
    public class SearchPage: BasePage
    {
        int _productCount = 39;
        public SearchPage(IWebDriver driver) : base(driver)
        {
           
        }

        public HomePage GoHome()
        {
            Click(By.ClassName("o-header__logo--img"));
            return new HomePage(_driver);
        }
        public SearchPage Scrolling()
        {
           ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollBy(0,30000);");
            return this;

        }
        public SearchPage MostProductClick()
        {
            Click(By.Id("moreContentButton"));
            return this;
        }
        public ProductPage RandomSelectProduct()
        {
            Random random = new Random();
            int index = random.Next(1, _productCount);
            string xPath = string.Format(".//*[@id='productList']/div[{0}]/div/div/div[1]/a[1]", index);
            Click(By.XPath(xPath));
            return new ProductPage(_driver);
        }
        //*[@id="productList"]/div[22]/div/div/div[2]/a[2]

    }
}
