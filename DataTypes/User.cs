using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class User<T> : Syncronizeable<T> where T : class
    {
        public string Nama { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
        public User(String Nama, String Email, String Password)
        {
            this.Nama = Nama;
            this.Email = Email;
            this.Password = Password;
        }
    }
}
