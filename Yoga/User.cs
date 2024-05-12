using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoga
{
    public class User
    {
        private int Id;
        public string Nama { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public static int UserCount = 0;
        
        public User(String Nama, String Email, String Password)
        {
            Id = ++UserCount;
            this.Nama = Nama;
            this.Email = Email;
            this.Password = Password;
        }
    }
}
