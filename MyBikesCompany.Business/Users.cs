using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesCompany.Business
{
    public class Users
    {
        private string _username;
        private string _password;

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }

        public Users(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public Users()
        {
            _username = "";
            _password = "";
        }
    }
}
