using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    //use control + . and use extract interface
    public class PersonModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //added to class (but doesn't affect anything that could break the class)
        //this is the firm implementation of the Accounts object
        public IAccounts AccountProcesser { get; set; } = new Accounts();

    }
}
