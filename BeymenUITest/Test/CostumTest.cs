using BeymenUITest.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace BeymenUITest.Test
{
   public class CostumTest
    {
        [Fact]
        public void Be_Able_Add_Two_Product()
        {
            //Arrange
            string searchProductKey = "pantolon";
            IWebDriver driver = new EdgeDriver();
            var homePage = new HomePage(driver);
            int size = 2;

            //Act
            homePage.GoHome().ClickLogin().GoHome().ClickFavorite().GoHome().ClickCart().GoHome();
            var searchPage = homePage.SearchProduct(searchProductKey).Scrolling().MostProductClick();
            var productPage = searchPage.RandomSelectProduct().SizeClick(size).AddCart();
            string productPrize = productPage.Prize();
            var cartPage = productPage.GoCart();
            string cartPrize = cartPage.Prize();
            cartPage.AddMore().Delete();
            homePage = cartPage.GoHome();
            bool isCartEmpty = homePage.IsCartEmpty();


            //Assert
            Assert.Equal(cartPrize, productPrize);
            Assert.True(isCartEmpty);
        }
    }
}
