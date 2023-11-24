using ST1010015_POE.Controllers;
using ST1010015_POE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ST1010015_POE.TESTS
{
    [TestClass]
    public class HomeControllerTests
    {
        private disasteralleviationfoundationdbContext contextDB = new disasteralleviationfoundationdbContext();
        [TestMethod]
        public void AllocateMoney()
        {
            var moneyLeft = contextDB.DonationsOfMoneys.Select(s => s.DonationAmount).Sum() - contextDB.AllocationOfMoneys.Select(s => s.AmountAllocated).Sum() - contextDB.PurchasesOfGoods.Select(a => a.AmountRequired).Sum();
            var allocatedValue = 100000;
            Assert.IsFalse(moneyLeft > allocatedValue);
        }

        [TestMethod]
        public void TestAddANewActiveDisasterView()
        {
            var controller = new HomeController();
            var result = controller.AddANewActiveDisaster() as ViewResult;
            Assert.AreEqual("AddANewActiveDisaster", result.ViewName);

        }

        [TestMethod]
        public void TestMakeAMoneyDonationView()
        {
            var controller = new HomeController();
            var result = controller.MakeAMoneyDonation() as ViewResult;
            Assert.AreEqual("MakeAMoneyDonation", result.ViewName);

        }


        [TestMethod]
        public void TestAddANewCategoryOfGoodsView()
        {
            var controller = new HomeController();
            var result = controller.AddANewCategoryOfGoods() as ViewResult;
            Assert.AreEqual("AddANewCategoryOfGoods", result.ViewName);

        }

        
    }
}
