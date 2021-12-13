using System;
using NUnit.Framework;
using OpenQA.Selenium;
using Thinkorswim.Tests.Driver;
using SeleniumExtras.PageObjects;

namespace Thinkorswim.Tests.Utils
{
    [SetUpFixture]
    public abstract class CommonConditions
    {
        protected IWebDriver Driver;
        
        [SetUp]
        public void InitBrowserAndLogin()
        {
            Log.Info($"Start test: {TestContext.CurrentContext.Test.MethodName}");
            Driver = DriverSingleton.GetWebDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://trade.thinkorswim.com/");
        }

        [TearDown]
        public void CloseBrowser()
        {
            //Log.Info($"Close test: {TestContext.CurrentContext.Test.MethodName}");
            //DriverSingleton.CloseWebDriver();
        }
    }
}