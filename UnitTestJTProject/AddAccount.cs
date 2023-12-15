using Microsoft.VisualStudio.TestTools.UnitTesting;
using PresentLayer;
using System;

namespace UnitTestJTProject
{
    [TestClass]
    public class AddAccount
    {
        private frmCreateAccount frmCreateAccount;
        [TestInitialize]
        public void Initialize()
        {
            frmCreateAccount = new frmCreateAccount();
        }
        [TestMethod]
        // add same username existed
        // Account with username "admin" existed
        public void TestSameUsername()
        {
            bool result = frmCreateAccount.AddAccount1("admin", "1111", 0);
            Assert.IsFalse(result);
        }
        [TestMethod]
        // add with blank password
        public void TestBlankPassword()
        {
            bool result = frmCreateAccount.AddAccount1("admin", null, 0);
            Assert.IsFalse(result);
        }
        [TestMethod]
        // add with blank username
        public void TestBlankUsername()
        {
            bool result = frmCreateAccount.AddAccount1(null, "1111", 0);
            Assert.IsFalse(result);

        }
        [TestMethod]
        // add with blank/blank
        public void TestBlank()
        {
            bool result = frmCreateAccount.AddAccount1(null, null, 0);
            Assert.IsFalse(result);

        }
        // Correct Add staff5 not exist in DB
        [TestMethod]
        // add with blank password
        public void TestCorrect()
        {
            bool result = frmCreateAccount.AddAccount1("staff5", "00000", 0);
            Assert.IsTrue(result);
            // Delete after test
            frmCreateAccount.DeleteAccount1("staff5");

        }
    }
}
