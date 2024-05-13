using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserClass
{
    public class User
    {
        private const int id { get; set; } = ++UserCount;
        private String name { get; set; }
        private String email { get; set; }
        private String password { get; set; }
        private static int UserCount = 0

    }
}
