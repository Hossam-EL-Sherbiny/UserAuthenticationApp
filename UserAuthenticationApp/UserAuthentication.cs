using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCryptNet = BCrypt.Net.BCrypt;

namespace UserAuthenticationApp
{
    public class UserAuthentication
    {
        private readonly Dictionary<string, string> _userCredentials;
        public UserAuthentication()
        {
            _userCredentials = new Dictionary<string, string>();
        }

        public void RegisterUser(string username, string password) 
        {
            if (!_userCredentials.ContainsKey(username))
            {
                string hashedPassword = HashedPassword(password);
                _userCredentials.Add(username, hashedPassword);
            }
            else
                throw new InvalidOperationException("Username already exists.");
        }

        public bool Login(string username, string password)
        {
            if (_userCredentials.ContainsKey(username))
            {
                string hashedPassword = _userCredentials[username];
                return BCryptNet.Verify(password, hashedPassword);
            }
            return false;
        }

        private string HashedPassword(string password)
        {
            string salt = BCryptNet.GenerateSalt();
            string hashedPassword = BCryptNet.HashPassword(password, salt);
            return hashedPassword;
        }
    }
}
