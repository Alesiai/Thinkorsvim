using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Thinkorswim.Tests.Utils;

namespace Thinkorswim.Tests.Pages
{ 
    public class ChartPF : PageFactoryBase
    {
        [FindsBy(How = How.CssSelector, Using = "button[data-testid=\"drawings-menu-button\"]")]
        private IWebElement _pencilButton;

        [FindsBy(How = How.CssSelector, Using = "button[data-testid=\"studys-table-customization-button\"]")]
        private IWebElement _studiesButton;

        [FindsBy(How = How.CssSelector, Using = "button[class=\"Button__SystemButton-lnusJv Button-jyKNMA OverlayContainerItem-bdKXZq fMbxLf\"]")]
        private IWebElement _fibonacciButton;

        [FindsBy(How = How.CssSelector, Using = "button[role=\"option\"]")]
        private IWebElement _ADXButton;
       
        [FindsBy(How = How.CssSelector, Using = "button[data-testid=\"overlay-container-close\"]")]
        private IWebElement _closeButton;
       
        private By _chart = By.ClassName("d3chart-container");

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
