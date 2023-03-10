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
            userRegistration.CheckLastName("Pundalik");
            userRegistration.CheckEmaild("abc.xyz@bl.co.in");
            userRegistration.CheckPhoneNumber("91 8668285117");
            userRegistration.CheckPassword("Password");
            userRegistration.CheckStringPassword("Aarti123");
            userRegistration.CheckNumericPassword("Aarti689");
            userRegistration.CheckSpecialCharacter("Aarti#");
            Console.ReadLine();
        }
    }
}
