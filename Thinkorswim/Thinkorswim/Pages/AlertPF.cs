using System.Threading;
using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Thinkorswim.Tests.Utils;
using Thinkorswim.Tests.Pages;

namespace Thinkorswim.Tests.Pages
{
    public class AlertPF : PageFactoryBase
    {
        [FindsBy(How = How.XPath, Using = "//*[@id=\"undefined input\"]")]
        private IWebElement _sumInput;

        private By _notification = By.XPath("/html/body/div[1]/div/div");

        [FindsBy(How = How.XPath, Using = "//*[@id=\"quote-details\"]/div[1]/header/div/div[3]/button")]
        private IWebElement _alertButton;

        [FindsBy(How = How.CssSelector, Using = "button[data-testid=\"operator-dropdown-value\"]")]
        private IWebElement _atOrAboveButton;

        [FindsBy(How = How.CssSelector, Using = "#tippy-8>div>div>div>div>div>ul>li:nth-child(3)")]
        private IWebElement _aboveButton;

        public AlertPF(IWebDriver driver) : base(driver) { }

        public AlertPF ClickAlertButton()
        {
            _alertButton.Click();

            Log.Info("Clicked alert button");
            return this;
        }
        public AlertPF SumIncerting(float betAmount)
        {
            _sumInput.SendKeys(Keys.Backspace);
            _sumInput.SendKeys(Keys.Backspace);
            _sumInput.SendKeys(Keys.Backspace);
            _sumInput.SendKeys(Keys.Backspace);
            _sumInput.SendKeys(Keys.Backspace);

            _sumInput.SendKeys(betAmount.ToString());

            Log.Info("Amount of bet inserted");
            return this;
        }
        public AlertPF AtOrAboveClick()
        {
            _atOrAboveButton.Click();

            Log.Info("Clicked to AT OR ABOVE BUTTON");
            return this;
        }

        public AlertPF AboveClick()
        {
            _aboveButton.Click();

            Log.Info("Clicked to ABOVE BUTTON");
            return this;
        }

        public AlertPF SubmitClick()
        {
            Log.Info("Clicked to submit button");
            
            return this;
        }
        public IReadOnlyCollection<IWebElement> FindNotification()
        {
            return Driver.FindElements(_notification);
        }

    }
}
