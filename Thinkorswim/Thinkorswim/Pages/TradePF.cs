using System.Threading;
using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Thinkorswim.Tests.Utils;


namespace Thinkorswim.Tests.Pages
{
    public class TradePF : PageFactoryBase
    { 
        [FindsBy(How = How.CssSelector, Using = "button[data-testid=\"TradeButton-buy\"]")]
        private IWebElement _buyButton;
        
        [FindsBy(How = How.CssSelector, Using = "input[aria-label=\"Quantity Input\"]")]
        private IWebElement _buyInput;

        [FindsBy(How = How.CssSelector, Using = "button[id=\"review-order-button\"]")]
        private IWebElement _reviewButton;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"send-order-button\"]")]
        private IWebElement _sendButton;

        [FindsBy(How = How.CssSelector, Using = "button[aria-label=\"Add Order Rule\"]")]
        private IWebElement _orderRuleButton;
        
        [FindsBy(How = How.CssSelector, Using = "button[aria-label=\"Add Vertical\"]")]
        private IWebElement _verticalButton;
        
        private readonly By _expressOrders = By.ClassName("trade-row");
        private By _notification = By.XPath("//*[@id=\"root\"]/div/div");

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
        public TradePF ClickVerticalButton()
        {
            _verticalButton.Click();

            Log.Info("Clicked vertical button");
            return this;
        }
        
        public TradePF ClickSendButton()
        {
            Thread.Sleep(2000);
            
            _sendButton.Click();
            
            Log.Info("Clicked send button");
            return this;
        }
        public string ChangedInput()
        {
            string chage = _buyInput.Text;

            Log.Info("0 changed to 1");
            return chage;
        }

        public TradePF OrderRule()
        {
            _orderRuleButton.Click();

            Log.Info("Clicked to order rule");
            return this;
        }

        public IReadOnlyCollection<IWebElement> GetOrder()
        {
            return Driver.FindElements(_expressOrders);
        }
        public IReadOnlyCollection<IWebElement> FindNotification()
        {
            return Driver.FindElements(_notification);
        }
    }
}