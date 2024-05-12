
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    //IUser
    public interface IUser
    {
        string get_username();
        string get_password();
        string get_user_type();
        void set_username(string username);
        void set_password(string password);
        void set_user_type(string user_type);

    }
    public class User : IUser
    {
        private string username;
        private string password;
        private string user_type;

        public User(){ }
        public User(string username, string password , string user_type)
        {
            this.username = username;
            this.password = password;
            this.user_type = user_type;
        }

        public string get_user_type()
        {
            return user_type;
        }

        public string get_username()
        {
            return username;
        }
        public string get_password()
        {
            return password;
        }

        public void set_username(string username)
        {
            this.username = username;
        }

        public void set_password(string password)
        {
            this.password = password;
        }

        public void set_user_type(string user_type)
        {
            this.user_type = user_type;
        }
    }
}
