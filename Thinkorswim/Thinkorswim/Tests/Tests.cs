using FluentAssertions;
using NUnit.Framework;
using Thinkorswim.Tests.Pages;
using Thinkorswim.Tests.Utils;

namespace Thinkorswim.Tests
{
    [TestFixture]
    public class Tests : CommonConditions
    {
        [Test]
        public void Thinkorswim_AddSymbolsToWatchList()
        {
            string nameOfNewWatchList = StringUtils.GetRandomString(8);

            var expressOrders = new ThinkorswimMainPF(Driver, true)
                .OpenWatchListPage()
                .InputNewNameOFWatchList(nameOfNewWatchList)
                .ClickSaveButton()
                .InputSymbol("DY")
                .ChoseSymbol()
                .AddToWatchlistButton()
              .watchList(nameOfNewWatchList);

            expressOrders.FindElement.Text.Should().Be("DY");
            expressOrders.Current.Should().NotBeNull();
        }
        [Test]
        public void Thinkorswim_CreateOrder()
        {
            int betAmount = 100;

            var expressOrders = new ThinkorswimMainPF(Driver, true)
                .OpenTradePage()
                .ClickBuyButton()
                .InputAmountOfBet(betAmount)
                .ClickReviewButton()
                .ClickSendButton()
                .GetOrder();

            expressOrders.Should().NotBeNullOrEmpty();
        }
        [Test]
        public void Thinkorswim_CreateOrderEdit()
        {
            int betAmount = 10;

            var expressOrders = new ThinkorswimMainPF(Driver, true)
                .OpenTradePage()
                .ClickBuyButton()
                .InputAmountOfBet(betAmount)
                .ClickReviewButton()
                .ClickSendButton()
                .GetOrder();

            expressOrders.Should().NotBeNullOrEmpty();
        }
        [Test]
        public void Thinkorswim_CreateFaildOrder()
        {
            int betAmount = 20000;

            var expressOrders = new ThinkorswimMainPF(Driver, true)
                .OpenTradePage()
                .ClickBuyButton()
                .InputAmountOfBet(betAmount)
                .ClickReviewButton()
                .ClickSendButton()
                .FindNotification();

            expressOrders.Should().NotBeEmpty();
        }
        [Test]
        public void Thinkorswim_ByZero()
        {
            int betAmount = 0;

            var expressOrders = new ThinkorswimMainPF(Driver, true)
                .OpenTradePage()
                .ClickBuyButton()
                .InputAmountOfBet(betAmount)
                .ClickReviewButton()
                .ChangedInput();

            expressOrders.Should().Be("");
        }
        [Test]
        public void Thinkorswim_CreateAlert()
        {
            float betAmount = 3302.43f;

            var expressOrders = new ThinkorswimMainPF(Driver, true)
                .OpenAlertPage()
                .ClickAlertButton()
                .SumIncerting(betAmount)
                .AtOrAboveClick()
                .AboveClick()
                .SubmitClick()
                .FindNotification();

            expressOrders.Should().NotBeNullOrEmpty();
        }
        [Test]
        public void Thinkorswim_CreateOrderWitnTimeRule()
        {
            int betAmount = 100;

            var expressOrders = new ThinkorswimMainPF(Driver, true)
                .OpenTradePage()
                .ClickBuyButton()
                .InputAmountOfBet(betAmount)
                .OrderRule()
                .GetOrder();

            expressOrders.Should().NotBeNullOrEmpty();
        }
        [Test]
        public void Thinkorswim_CreateFibonacci()
        {
            var expressOrders = new ThinkorswimMainPF(Driver, true)
                .OpenChartPage()
                .ClickPencilButton()
                .ClickFibonacciButton()
                .GetChart();

            expressOrders.Should().NotBeNullOrEmpty();
        }
        [Test]
        public void Thinkorswim_CreateMultyChart()
        {
            var expressOrders = new ThinkorswimMainPF(Driver, true)
                .OpenFullChartPage()
                .ClickStudiesButton()
                .ClickADXButton()
                .ClickCloseButton()
                .GetChart();

            expressOrders.Should().NotBeNullOrEmpty();
        }
        [Test]
        public void Thinkorswim_CreateOrderWitnVerticalOption()
        {
            var expressOrders = new ThinkorswimMainPF(Driver, true)
                .OpenTradePage()
                .ClickVerticalButton()
                .ClickReviewButton()
                .ClickSendButton()
                .GetOrder();

            expressOrders.Should().NotBeNullOrEmpty();
        }
    }
}
