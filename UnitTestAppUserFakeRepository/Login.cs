using Microsoft.VisualStudio.TestTools.UnitTesting;
using P3;

namespace UnitTestAppUserFakeRepository
{
    [TestClass]
    public class Login
    {
        [TestMethod]
        public void LoginWithCorrectCredentialsSuccessful()
        {
            //Arange
            FakeAppUserRepository repo = new FakeAppUserRepository();
            //Act
            //Assert
        }

        [TestMethod]
        public void LoginWithIncorrectCredentialsFail()
        {
        }
    }
}
