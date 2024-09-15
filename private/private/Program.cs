using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @private
{
    internal class Program
    {
        class Login 
        {
            public string felhasználónév;
            private string jelszó;

            public Login(string felhasználónév, string jelszó)
            {
                this.felhasználónév = felhasználónév;
                this.jelszó = jelszó;
  
            }
            

        }
        static void Main(string[] args)
        {
            Login login = new Login("Lackó", "Nemtudom66.");
            Console.WriteLine(login.felhasználónév);
        
        }
    }
}
