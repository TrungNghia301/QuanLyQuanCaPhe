using Microsoft.VisualStudio.TestTools.UnitTesting;
using PresentLayer;
using System;

namespace UnitTestJTProject
{
    [TestClass]
    public class UpdateCoffee
    {
        private frmSuaHang frmsuahang;
        //Pre-Condition Coffee with information "66/testCoffee/, 0, 0,12/14/2023,12/14/2023,""" exist
        [TestInitialize]
        public void Initialize()
        {
            frmsuahang = new frmSuaHang("66", "testCoffee", 0, 0, 0, new DateTime(2023, 12, 14), new DateTime(2023, 12, 14), "");
        }
        [TestMethod]
        // Test with correct testCoffee to Coffee and Coffee don't have in Database
        public void TestUpdateCorrect()
        {
          bool result  =   frmsuahang.UpdateCoffee(66,"Coffee",0, new DateTime(2023, 12, 14), new DateTime(2023, 12, 14), 0,0, "");
          Assert.IsTrue(result);
          //reset
          frmsuahang.UpdateCoffee(66, "testCoffee", 0, new DateTime(2023, 12, 14), new DateTime(2023, 12, 14), 0, 0, "");
        }
        [TestMethod]
        // Test with wrong testCoffee to blank
        public void TestUpdateBlankName()
        {
            bool result = frmsuahang.UpdateCoffee(66, "", 0, new DateTime(2023, 12, 14), new DateTime(2023, 12, 14), 0, 0, "");
            Assert.IsFalse(result);
        }
        [TestMethod]
        // Test with same name: testCoffee to Mocha and Mocha existed in DB
        public void TestUpdateSameName()
        {
            bool result = frmsuahang.UpdateCoffee(66, "Mocha", 0, new DateTime(2023, 12, 14), new DateTime(2023, 12, 14), 0, 0, "");
            Assert.IsFalse(result);
        }

    }
}
