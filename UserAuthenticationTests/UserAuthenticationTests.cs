using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UserAuthenticationApp.Tests
{
    public class UserAuthenticationTests
    {
        [Fact]
        public void RegisterUser_ShouldAddUserCredentials()
        {
            // Arrange
            UserAuthentication auth = new();
            string username = "testuser";
            string password = "password123";

            // Act
            auth.RegisterUser(username, password);

            // Assert
            Assert.True(auth.Login(username, password));
        }
        [Fact]
        public void RegisterUser_ShouldThrowException_WhenUsernameExists()
        {
            // Arrange
            UserAuthentication auth = new();
            string username = "existinguser";
            string password = "password123";
            auth.RegisterUser(username, password);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => auth.RegisterUser(username, password));
        }
        [Fact]
        public void Login_ShouldReturnTrue_WhenCredentialsAreCorrect()
        {
            // Arrange
            UserAuthentication auth = new();
            string username = "existinguser";
            string password = "password123";
            auth.RegisterUser(username, password);

            // Act
            bool retsult = auth.Login(username, password);

            // Assert
            Assert.True(retsult);
        }
        [Fact]
        public void Login_ShouldReturnFalse_WhenCredentialsAreFalse()
        {
            UserAuthentication auth = new();
            string username = "existinguser";
            string password = "password123";
            auth.RegisterUser(username, password);

            // Act
            bool result = auth.Login(username, "incorrectpassword");

            // ASSERT
            Assert.False(result);
        }
    }
}
