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
            // Arrange
            FakeAppUserRepository repo = new FakeAppUserRepository();
            // Act
            bool response = repo.Login("Steve1234", "Billy");
            // Assert
            Assert.IsTrue(response);
            Assert.AreEqual(true, repo.GetByUserName("Steve1234").isAuthenticated);
        }
        
        [TestMethod]
        public void LoginWithIncorrectCredentialsFail()
        {
            // Arrange
            FakeAppUserRepository repo = new FakeAppUserRepository();
            // Act
            bool response = repo.Login("Steve1234", "Billy1234");
            // Assert
            Assert.IsFalse(response);
            Assert.AreEqual(false, repo.GetByUserName("Steve1234").isAuthenticated);

        }
    }
}
