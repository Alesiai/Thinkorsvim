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
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/main/div[2]/div[1]/section/div[1]/header/div/div[3]/button")]
        private IWebElement _alertButton;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"undefined input\"]")]
        private IWebElement _sumInput;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/main/div[2]/div[1]/section/div[1]/header/div/div[2]/div[2]/div[2]/div/button")]
        private IWebElement _atOrAboveButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/main/div[2]/div[1]/section/div[1]/header/div/div[2]/div[2]/div[2]/div/div/div/div/div/div/div/ul/li[3]")]
        private IWebElement _aboveButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/main/div[2]/div[1]/section/div[1]/header/div/div[2]/div[3]/button[2]")]
        private IWebElement _submitButton;

        private By _notification = By.XPath("/html/body/div[1]/div/div");

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
            _submitButton.Click();

            Log.Info("Clicked to submit button");
            
            return this;
        }
        public IReadOnlyCollection<IWebElement> FindNotification()
        {
            return Driver.FindElements(_notification);
        }

    }
}
