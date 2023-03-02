using FluentAssertions;
using Lib;
using NUnit.Framework;


namespace Tests
{
    [TestFixture]
    public class SimpleOrderTests : BaseTest
    {
        [Test]
        public void CreateSimpleOrder()
        {
            Driver.Navigate().GoToUrl("https://smereka.com/");

            HomePageSmereka homePage = new HomePageSmereka();
            var pageTitle = homePage.NamePage();

            pageTitle.Should().Contain("Купить искусственную");

            HeaderComponent headerComponent = new HeaderComponent();
            headerComponent.SelectMenu("Продукция","Исскуственные ели");

            CatalogTree catalogTree = new CatalogTree();
            var pageCatalog = catalogTree.NamePageCatalog();

            pageCatalog.Should().Be("Искусственные елки");

            catalogTree.SelectTree();

            TreeSelect treeSelect = new TreeSelect();


            var availablePrices = treeSelect.Prices();


            var priceToClick = availablePrices.ElementAt(1);

            treeSelect.TreeClick(priceToClick);

           
            Basket basket = new Basket();
            basket.BasketClick();

            
            BasketProducts basketProducts = new BasketProducts();
            //basketProducts.PlaceOrder();
            basketProducts.LastPurshaseB();
            

            //new PlaceOrder().FillCustomer();

            //new PlaceOrder().LastPurshasPO();

            //new PlaceOrder().ClickOrderSubmit();




        }
    }
}
