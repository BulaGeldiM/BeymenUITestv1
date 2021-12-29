using BeymenUITest.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeymenUITest.Page
{
  public class FavoritePage : BasePage

   {
        public FavoritePage(IWebDriver driver) : base(driver)
        {

        }

        public HomePage GoHome()
        {
            Click(By.ClassName("o-header__logo--img"));
            return new HomePage(_driver);
        }
    }
}
