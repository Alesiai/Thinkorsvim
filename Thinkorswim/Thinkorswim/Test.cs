using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace Thinkorswim.Tests
{
    public class Tests
    {
        [Fact]
        public void ThinkorswimBytrades()
        {
            var driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("https://trade.thinkorswim.com/");


            driver.FindElement(By.CssSelector("input[name='su_username']")).SendKeys("alesiai1");
            driver.FindElement(By.CssSelector("input[name='su_password']")).SendKeys("ve4nostp");
            driver.FindElement(By.CssSelector("input[name='authorize']")).Click();
            
            driver.FindElement(By.CssSelector("#positions-nav-btn")).Click();
            driver.FindElement(By.CssSelector("#trade-nav-btn")).Click();
            driver.FindElement(By.CssSelector("button[data-testid='TradeButton-buy']")).Click();

            var nameInput = driver.FindElement(By.CssSelector("input[aria-label='Quantity Input']"));
            nameInput.Clear();
            nameInput.SendKeys("1");

            driver.FindElement(By.CssSelector("#review-order-button")).Click();

            driver.FindElement(By.CssSelector("#send-order-button")).Click();

            var expectedPopup = driver.FindElement(By.CssSelector(".alert-enter-done"));

            Assert.True(expectedPopup != null);

            driver.Quit();
        }
    }
}
