using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    //make the new class public and control+. to implement the Interface
    public class ManagerModel : IApplicantModel
    {
        //remove throw new NotImplementExceptions because we aren't changing what we get/set
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountProcesser { get; set; } = new ManagerAccounts();
    }
}
