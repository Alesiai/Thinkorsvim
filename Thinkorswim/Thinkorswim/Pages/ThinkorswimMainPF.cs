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

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div/main/nav/div/div[2]/button")]
        private IWebElement _tradeButton;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"watchlist-header\"]/div[2]/div[2]/button")]
        private IWebElement _watchListButton;



        public ThinkorswimMainPF(IWebDriver driver,bool IsFirst) : base(driver) 
        {
            _UserName.SendKeys("alesiai3");
            _UserPassword.SendKeys("ve4nostp");
            _CobfirmBtn.Click();
        }
        public ThinkorswimMainPF(IWebDriver driver) : base(driver)
        { }


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

        //public ExpressOrderMenuPF OpenExpressOrderMenu()
        //{
        //    _expressOrderButton.Click();

        //    Log.Info("Clicked on express order button");

        //    return new ExpressOrderMenuPF(Driver);
        //}

        //public PendingTradePF OpenPendingTradeMenu()
        //{
        //    _pendingTradeButton.Click();

        //    Log.Info("Clicked on pending trade button");

        //    return new PendingTradePF(Driver);
        //}

        //public AssetsPF OpenAssets()
        //{
        //    _selectedAssetButton.Click();

        //    Log.Info("Click on assets menu button");

        //    return new AssetsPF(Driver);
        //}

        //public ChartTypeMenuPF OpenChartTypeMenu()
        //{
        //    _chartTypeMenuButton.Click();

        //    Log.Info("Chart type menu opened");

        //    return new ChartTypeMenuPF(Driver);
        //}

        //public MultiChartMenuPF OpenMulChartMenu()
        //{
        //    _multiChartMenuButton.Click();

        //    Log.Info("Multi-chart menu opened");

        //    return new MultiChartMenuPF(Driver);
        //}

        //public DrawingsMenuPF OpenDrawingsMenu()
        //{
        //    _drawingsMenuButton.Click();

        //    Log.Info("Drawings menu opened");

        //    return new DrawingsMenuPF(Driver);
        //}

        //public ChatMenuPF OpenChatMenu()
        //{
        //    _chatMenuButton.Click();

        //    Log.Info("Chat menu opened");

        //    return new ChatMenuPF(Driver);
        //}
    }
}