using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_UserRegistration
{
    public class UserRegistration
    {
        List<RegistrationModel> registrationModels = new List<RegistrationModel>();
        public UserRegistration()
        {
            RegistrationModel registration = new RegistrationModel();
            registrationModels.Add(registration);
        }
        public void CheckFirstName(string firstName)
        {
            if (registrationModels.Any(x => x.FirstName.IsMatch(firstName)))
            {
                Console.WriteLine("Its a valid first name");
            }
            else
            {
                Console.WriteLine("Its a not valid first name");
            }
        }
        public void CheckLastName(string lastName)
        {
            if (registrationModels.Any(x => x.LastName.IsMatch(lastName)))
            {
                Console.WriteLine("Its a valid Last name");
            }
            else
            {
                Console.WriteLine("Its a not valid Last name");
            }
        }
        public void CheckEmaild(string emailId)
        {
            if (registrationModels.Any(x => x.EmailId.IsMatch(emailId)))
            {
                Console.WriteLine("Its a valid email Id");
            }
            else
            {
                Console.WriteLine("Its a not valid email Id");
            }
        }
    }
}
    

