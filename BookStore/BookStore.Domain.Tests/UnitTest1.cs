using BookStore.Domain.Account.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookStore.Domain.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var verificationUser = "NADA";
            var user = new User("fabricio", "1234");
            user.Verify(verificationUser);

            Assert.AreEqual(true, user.Verified);
        }
    }
}
