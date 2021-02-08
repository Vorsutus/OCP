using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    //This type of account may be different than the account type implemented for staff, thus it is DRY compliant
    //this impliments and extends the Accounts class
    public class ManagerAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            //email is created differently
            output.EmailAddress = $"{ person.FirstName.Substring(0, 1) }{person.LastName}@HydraCorp.com";

            //setting flag to true for being a manager
            output.IsManager = true;

            return output;
        }
    }
}
