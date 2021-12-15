using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Thinkorswim.Tests.Utils;
using Thinkorswim.Tests.Pages;

namespace Thinkorswim.Tests.Pages
{
    public class WatchListPF : PageFactoryBase
    {
        [FindsBy(How = How.XPath, Using = "//*[@id=\"watchlist-header\"]/div[2]/div[2]/div/form/input")]
        private IWebElement _nameOfNewWatchList;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"watchlist-header\"]/div[2]/div[2]/div/form/button")]
        private IWebElement _saveButton;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"symbol-search\"]")]
        private IWebElement _symbolInput;

        [FindsBy(How = How.ClassName, Using = "dropdown-index__0")]
        private IWebElement _choseSympol;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"quote-details\"]/div[1]/header/div/div[3]/div/button")]
        private IWebElement _addToWatchListButton;

        [FindsBy(How = How.CssSelector, Using = "#watchlist-row-0>td:nth-child(1)>div>div>span[data-symbol=\"DY\"]")]
        private IWebElement _findDYinWatchList;

        public WatchListPF(IWebDriver driver) : base(driver) { }

        public WatchListPF InputNewNameOFWatchList(string newName)
        {
            _nameOfNewWatchList.SendKeys(newName.ToString());

            Log.Info("Insert name of new watchlist");
            return this;
        }

        public WatchListPF ClickSaveButton()
        {
            _saveButton.Click();

            Log.Info("Click Save for saving new watchlist");
            return this;
        }

        public WatchListPF InputSymbol(string name)
        {
            _symbolInput.SendKeys(name.ToString());

            Log.Info("Insert name of symbol");
            return this;
        }

        public WatchListPF ChoseSymbol()
        {
            _choseSympol.Click();

            Log.Info("Click to symbol");
            return this;
        }

        public WatchListPF AddToWatchlistButton()
        {
            _addToWatchListButton.Click();

            Log.Info("Click to symbol");
            return this;
        }

        

        public (IWebElement Current, IWebElement FindElement) watchList(string nameOfList)
        {
            By _current = By.CssSelector("span[title='" + nameOfList + "']");
            var current = Driver.FindElement(_current);
            current.Click();

            return (current, _findDYinWatchList);
        }
    }
}
