using System.Transactions;
using Resutest.Helpers;

namespace Resutest
{
    public class RegisterTests : Helpers.BaseTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task BaseRegistrationTest()
        {
            using (TransactionScope scope = Helper.CreateTransactionScope())
            {
                string email = Guid.NewGuid().ToString() + "@test.com";

                // validate: should not be in the DB
                var emailValidationResult  = await authBL.ValidateEmail(email);
                Assert.IsNull(emailValidationResult);

                // create user
                int userId = await authBL.CreateUser(
                    new Resunet.DAL.Models.UserModel()
                    {
                        Email = email,
                        Password = "qwer1234"
                    });

                Assert.Greater(userId, 0);

                // validate: should be in the DB
                emailValidationResult = await authBL.ValidateEmail(email);
                Assert.IsNull(emailValidationResult);
            }
        }
    }
}