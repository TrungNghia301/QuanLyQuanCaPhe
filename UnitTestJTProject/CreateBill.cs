using Microsoft.VisualStudio.TestTools.UnitTesting;
using PresentLayer;
using System;

namespace UnitTestJTProject
{
    [TestClass]
    public class CreateBill
    {
        private frmHome frmhome;
        private frmThemHang frmthemhang;
        private frmManage frmmanage;
        [TestInitialize]
        public void Initialize()
        {
            frmhome = new frmHome();
            frmthemhang = new frmThemHang();
            frmmanage = new frmManage();
        }
        [TestMethod]
        // Test Coffee with name "BlackBrown" have in store to create bill
        public void TestMethod1()
        {
            ////add "BlackBrown" to db to test
            //string coffeeName = "BlackBrown";
            //frmthemhang.AddCoffee(coffeeName, 100, DateTime.Now, DateTime.Now.AddDays(30), 12000, 35000, "");
            ////Test
            //bool result = frmhome.CreateBill()
            //frmmanage.DeleteCoffee(null, "BlackBrown");
        }
    }
}
