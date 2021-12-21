using Thinkorswim.Tests.Utils;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Thinkorswim.Tests.Pages
{
    public class ThinkorswimMainPF : PageFactoryBase
    {
        #region
        [FindsBy(How = How.XPath, Using = "//*[@id=\"username0\"]")]
        private IWebElement _UserName;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"password1\"]")]
        private IWebElement _UserPassword;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"accept\"]")]
        private IWebElement _CobfirmBtn;
        #endregion
        [FindsBy(How = How.CssSelector, Using = "button[data-testid=\"trade-page-button\"]")]
        private IWebElement _tradeButton;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"watchlist-header\"]/div[2]/div[2]/button")]
        private IWebElement _watchListButton;

        [FindsBy(How = How.CssSelector, Using = "button[data-testid=\"charts-page-button\"]")]
        private IWebElement _chartButton;

        public ThinkorswimMainPF(IWebDriver driver) : base(driver) { LogIn(); }

        public TradePF OpenTradePage()
        {
            _tradeButton.Click();

            Log.Info("Clicked on trade button");

            return new TradePF(Driver);
        }

        public WatchListPF OpenWatchListPage()
        {
            _watchListButton.Click();

            Log.Info("Clicked on watchlist button");

            return new WatchListPF(Driver);
        }

        public AlertPF OpenAlertPage()
        {
            _tradeButton.Click();

            Log.Info("Clicked on alert button");

            return new AlertPF(Driver);
        }

        public ChartPF OpenChartPage()
        {
            _tradeButton.Click();

            Log.Info("Clicked on chart button");

            return new ChartPF(Driver);
        }

        public ChartPF OpenFullChartPage()
        {
            _chartButton.Click();

            Log.Info("Clicked on full chart button");

            return new ChartPF(Driver);
        }

        private void LogIn()
        {
            _UserName.SendKeys("alesiai3");
            _UserPassword.SendKeys("ve4nostp");
            _CobfirmBtn.Click();
        }
    }
}