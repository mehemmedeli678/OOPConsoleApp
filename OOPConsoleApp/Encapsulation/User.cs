using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp.Encapsulation
{
    public class User
    {
         private string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public string Name;
        public string Password { get; set; }
        public  string Token {get; private set; }

        public void GenerateToken(string token)
        {
            this.Token = string.Join(token, chars);
        }
    }
}
