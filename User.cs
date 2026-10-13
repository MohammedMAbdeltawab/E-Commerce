using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce
{
    public class User
    {
        public  int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public  string Email { get; set; } = string.Empty;
        public  string Password { get; set; } = string.Empty;
        public Role Role { get; set; } = default!;
    }
}
