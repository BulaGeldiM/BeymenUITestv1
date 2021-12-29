using BeymenUITest.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;

namespace BeymenUITest
{
    class Program
    {
        static void Main(string[] args)
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
           //string cartPrize = cartPage.Prize();
            cartPage.AddMore().Delete();
            homePage = cartPage.GoHome();
            bool isCartEmpty = homePage.IsCartEmpty();



            //if (cartPrize == productPrize)
            //{
            //    Console.WriteLine("fiyatlar eşit");
            //}
            //else
            //{
            //    Console.WriteLine("fiyatlar farklı");
            //}

            if (isCartEmpty)
            {
                Console.WriteLine("ürün yok");
            }
            else
            {
                Console.WriteLine("ürün var");
            }
            Console.ReadLine();
        }
    }
}
