using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public class ExecutiveModel : IApplicantModel
    {
        //remove throw new NotImplementExceptions because we aren't changing what we get/set
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Initialize as a new executive account
        public IAccounts AccountProcesser { get; set; } = new ExecutiveAccounts();
    }
}
