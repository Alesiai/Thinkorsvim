using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Thinkorswim.Tests.Utils;

namespace Thinkorswim.Tests.Pages
{
    public class WatchListPF : PageFactoryBase
    {
        [FindsBy(How = How.CssSelector, Using = "input[placeholder=\"Watchlist name\"]")]
        private IWebElement _nameOfNewWatchList;
        
        [FindsBy(How = How.CssSelector, Using = "button[data-testid=\"watchlist-save-button\"]")]
        private IWebElement _saveButton;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"symbol-search\"]")]
        private IWebElement _symbolInput;

        [FindsBy(How = How.ClassName, Using = "dropdown-index__0")]
        private IWebElement _choseSympol;
        
        [FindsBy(How = How.CssSelector, Using = "button[data-testid=\"add-symbol-to-watchlist-dropdown-value\"]")]
        private IWebElement _addToWatchListButton;

        [FindsBy(How = How.CssSelector, Using = "span[data-symbol=\"DY\"]")]
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
