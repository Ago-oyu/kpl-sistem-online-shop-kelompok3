using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend
{
    public class Product
    {
        [Key]
        public string? id { get; set; }
        public string name { get; set; }
        public int stock { get; set; }
    }
    public class User
    {
        [Key]
        public string? id { get; set; }
        public string name { get; set; }
        public Int64 phoneNumber { get; set; }
    }
}
