using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lambda_UserRegistration
{
    public class RegistrationModel
    {
        public Regex FirstName = new Regex(@"^[A-Z][a-z]{3,}?");
        public Regex LastName = new Regex(@"^[A-Z][a-z]{3,}?");
        public Regex EmailId = new Regex(@"^[a-zA-Z0-9]+[-.+_]{0,1}[a-zA-Z0-9]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$");
        public Regex PhoneNumber = new Regex(@"[0-9]{2}[ ][0-9]{10}");
        public Regex PassWord = new Regex(@"[A-Z]{1}[a-z0-9]");
        public Regex StringPassWord = new Regex(@"[A-Z]{1,}[a-z0-9]");
        public Regex NumericPassWord = new Regex(@"[a-zA-Z][0-9]{1,}");
        public Regex SpecialCharacter = new Regex(@"[0-9a-zA-Z][!@#$%&*]{1}");
    }
}
    

