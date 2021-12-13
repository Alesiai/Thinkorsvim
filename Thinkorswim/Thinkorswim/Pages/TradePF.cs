using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Thinkorswim.Tests.Utils;
using Thinkorswim.Tests.Pages;

namespace Thinkorswim.Tests.Pages
{
    public class TradePF : PageFactoryBase
    {
        [FindsBy(How = How.XPath, Using = "//*[@id=\"quote-details\"]/div[2]/div[2]/div[2]/button")]
        private IWebElement _buyButton;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"tradeTicket-0\"]/div[1]/input")]
        private IWebElement _buyInput;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"review-order-button\"]")]
        private IWebElement _reviewButton;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"send-order-button\"]")]
        private IWebElement _sendButton;

        public TradePF(IWebDriver driver) : base(driver) { }

        public TradePF ClickBuyButton()
        {
            _buyButton.Click();

            Log.Info("Clicked buy button");
            return this;
        }

        public TradePF InputAmountOfBet(float betAmount)
        {
            _buyInput.SendKeys(Keys.Backspace);
            _buyInput.SendKeys(Keys.Backspace);
            _buyInput.SendKeys(Keys.Backspace);

            _buyInput.SendKeys(betAmount.ToString());

            Log.Info("Amount of bet inserted");
            return this;
        }

        public TradePF ClickReviewButton()
        {
            _reviewButton.Click();

            Log.Info("Clicked review button");
            return this;
        }

        public TradePF ClickSendButton()
        {
            _sendButton.Click();

            Log.Info("Clicked send button");
            return this;
        }

        private readonly By _expressOrders = By.ClassName("trade-row");
        public IReadOnlyCollection<IWebElement> GetOrder()
        {
            return Driver.FindElements(_expressOrders);
        }
    }
}