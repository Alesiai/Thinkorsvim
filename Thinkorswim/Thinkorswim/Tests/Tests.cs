using FluentAssertions;
using NUnit.Framework;
using Thinkorswim.Tests.Pages;
using Thinkorswim.Tests.Utils;

namespace Thinkorswim.Tests
{
    [TestFixture]
    //[Parallelizable(ParallelScope.Children)]
    public class Tests : CommonConditions
    {
        //[Test]
        //public void Thinkorswim_CreateOrder()
        //{
        //    int betAmount = 100;

        //    var expressOrders = new ThinkorswimMainPF(Driver)
        //        .OpenTradePage()
        //        .ClickBuyButton()
        //        .InputAmountOfBet(betAmount)
        //        .ClickReviewButton()
        //        .ClickSendButton()
        //        .GetOrder();

        //    expressOrders.Should().NotBeNullOrEmpty();
        //}

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
            //    .InputAmountOfBet(betAmount)
            //    .ClickReviewButton()
            //    .ClickSendButton()
            //    .GetOrder();

            //expressOrders.Should().NotBeNullOrEmpty();
        }
    }
}
