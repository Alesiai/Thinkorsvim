using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Thinkorswim.Tests.Utils;

namespace Thinkorswim.Tests.Pages
{ 
    public class ChartPF : PageFactoryBase
    {//*
        [FindsBy(How = How.CssSelector, Using = "button[data-testid=\"drawings-menu-button\"]")]
        private IWebElement _pencilButton;

        [FindsBy(How = How.CssSelector, Using = "button[data-testid=\"studys-table-customization-button\"]")]
        private IWebElement _studiesButton;

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/main/div[2]/section/div/div[3]/div[1]/div[1]/div[2]/div[1]/div[1]/div[5]/div[2]/div/div[2]/button[4]")]
        private IWebElement _fibonacciButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/main/div[2]/section/div[2]/div[1]/div[1]/div[2]/div[1]/div/div[3]/div/div[2]/div/div/button[1]")]
        private IWebElement _ADXButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/main/div[2]/section/div[2]/div[1]/div[1]/div[2]/div[1]/div/div[3]/button")]
        private IWebElement _closeButton;

        private By _chart = By.XPath("//*[@id=\"charts-wrapper\"]/div[2]/div[1]/div/div[5]/div[5]");

        public ChartPF(IWebDriver driver) : base(driver) { }

        public ChartPF ClickPencilButton()
        {
            _pencilButton.Click();

            Log.Info("Clicked pencil button on chart");
            return this;
        }
        public ChartPF ClickStudiesButton()
        {
            _studiesButton.Click();

            Log.Info("Clicked studies button on chart");
            return this;
        }
        public ChartPF ClickCloseButton()
        {
            _closeButton.Click();

            Log.Info("Clicked close button");
            return this;
        }
        public ChartPF ClickFibonacciButton()
        {
            _fibonacciButton.Click();

            Log.Info("Clicked fibonacci button on chart");
            return this;
        }
        public ChartPF ClickADXButton()
        {
            _ADXButton.Click();

            Log.Info("Clicked ADX button on chart");
            return this;
        }
        public IReadOnlyCollection<IWebElement> GetChart()
        {
            return Driver.FindElements(_chart);
        }

    }
}
