using Microsoft.VisualStudio.TestTools.UnitTesting;
using PresentLayer;
using System;

namespace UnitTestJTProject
{
    [TestClass]
    public class UpdateUser
    {
        private frmManage frmmanage;
        [TestInitialize]
        public void Initialize()
        {
            frmmanage = new frmManage();
        }
        [TestMethod]
        // test correct update user
        public void TestCorrect()
        {
            //add usser to test update with account is "testAccount"
            frmmanage.AddNV("N20", "Nhân viên để xóa", ".", "0", "0", 0, "testAccount");
            bool result = frmmanage.UpdateNV("N20", "Nhan Vien Da Sua", "", "0", "0", 0, "testAccount");
            Assert.IsTrue(result);
            // Delete affter test;
            frmmanage.DeleteNV("N20");
        }
        [TestMethod]
        // test with same id user
        // user N01 existed in DB change N20 -> N01
        public void TestSameIdUser()
        {
            //add usser to test update with account is "testAccount"
            frmmanage.AddNV("N20", "Nhân viên để xóa", ".", "0", "0", 0, "testAccount");
            bool result = frmmanage.UpdateNV("N01", "Nhan Vien Da Sua", "", "0", "0", 0, "testAccount");
            Assert.IsFalse(result);
            // Delete affter test;
            frmmanage.DeleteNV("N20");

        }
        [TestMethod]
        // test with same username account
        // Account with username "admin" is of N01 then change "testAccount" to "admin"
        public void TestSameUsername()
        {
            //add usser to test update with account is "testAccount"
            frmmanage.AddNV("N20", "Nhân viên để xóa", ".", "0", "0", 0, "testAccount");
            bool result = frmmanage.UpdateNV("N20", "Nhan Vien Da Sua", "", "0", "0", 0, "admin");
            Assert.IsFalse(result);
            // Delete affter test;
            frmmanage.DeleteNV("N20");
        }
        [TestMethod]
        // test with blank id
        public void TestBlankId()
        {
            //add usser to test update with account is "testAccount"
            frmmanage.AddNV("N20", "Nhân viên để xóa", ".", "0", "0", 0, "testAccount");
            bool result = frmmanage.UpdateNV(null, "Nhan Vien Da Sua", "", "0", "0", 0, "testAccount");
            Assert.IsFalse(result);
            // Delete affter test;
            frmmanage.DeleteNV("N20");

        }
        [TestMethod]
        // test with blank username
        public void TestBlankUsername()
        {
            //add usser to test update with account is "testAccount"
            frmmanage.AddNV("N20", "Nhân viên để xóa", ".", "0", "0", 0, "testAccount");
            bool result = frmmanage.UpdateNV("N20", null, "", "0", "0", 0, "testAccount");
            Assert.IsFalse(result);
            // Delete affter test;
            frmmanage.DeleteNV("N20");

        }
    }
}
