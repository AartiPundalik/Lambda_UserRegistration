using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_UserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserRegistration userRegistration = new UserRegistration();
            userRegistration.CheckFirstName("Aarti");
            Console.ReadLine();
        }
    }
}
