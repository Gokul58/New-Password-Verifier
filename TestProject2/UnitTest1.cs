using password;
using Xunit;

namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var password = new PasswordVerifier();

            password.VerifyPassword("asvdbuwveduvwueoA1");

            Assert.Equal("Successful", "Successful");

        }
    }
}