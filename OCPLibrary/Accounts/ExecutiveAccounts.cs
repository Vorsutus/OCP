using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            //email is created differently
            output.EmailAddress = $"{ person.FirstName }.{person.LastName}@HailHydra.com";

            //setting flag to true for being a executive and manager
            output.IsManager = true;
            output.IsExecutive = true;

            return output;
        }
    }
}
