using Microsoft.VisualStudio.TestTools.UnitTesting;
using PresentLayer;
using System;

namespace UnitTestJTProject
{
    [TestClass]
    public class DeleteAccount
    {
        private frmCreateAccount frmCreateAccount;
        [TestInitialize]
        public void Initialize()
        {
            frmCreateAccount = new frmCreateAccount();
        }
        // Create a new account "staff5" and test delete
        [TestMethod]
        public void TestCorrect()
        {
            frmCreateAccount.AddAccount1("staff5","00000",0);
            bool result = frmCreateAccount.DeleteAccount1("staff5"); 
            Assert.IsTrue(result);  
        }
        [TestMethod]
        // Delete blank value
        public void TestBlankvalue ()
        {
            string c = null;
            bool result = frmCreateAccount.DeleteAccount1(c);
            Assert.IsFalse(result);
        }
    }
}
