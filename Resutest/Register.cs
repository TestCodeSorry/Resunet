using System.Transactions;
using Resutest.Helpers;

namespace Resutest

{
    public class RegisterTest : Helpers.BaseTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            using (TransactionScope scope = Helper.CreateTransactionScope())
                Assert.Pass();
        }
    }
}