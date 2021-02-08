using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public class NinjaAccounts : IAccounts
    {

        public EmployeeModel Create(IApplicantModel person)
            {
                EmployeeModel output = new EmployeeModel();

                output.FirstName = person.FirstName;
                output.LastName = person.LastName;
                //email is created differently
                output.EmailAddress = $"Shinobi-{person.FirstName}@Shadow.com";

                //setting flag to true for being a executive and manager
                output.IsManager = true;
                output.IsCorpo_Assassin = true;

                return output;
            }
        }
}
