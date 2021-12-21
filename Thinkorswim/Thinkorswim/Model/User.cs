using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thinkorswim.Model
{
    class User
    {
        private string _account;
        public string Account
        {
            get
            {
                return _account;
            }
            set
            {
                _account = value;
            }
        }

        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public User(string tradingАccount, string password)
        {
            _account = tradingАccount;
            Password = password;
        }
    }
}
