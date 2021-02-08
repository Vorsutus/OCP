using OCPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<PersonModel> applicants = new List<PersonModel> 
            //adding IApplicant that can be added to easily
            //IApplicant can include any Model than implements the IApplicant Interface
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel { FirstName = "Tim", LastName = "Corey" },
                //new PersonModel { FirstName = "Sue", LastName = "Storm" },
                new ManagerModel { FirstName = "Sue", LastName = "Storm" }, //this is better because it works off a different model contained in the IApplicants
                new ExecutiveModel { FirstName = "Nancy", LastName = "Roman" }, //this is better because it works off a different model contained in the IApplicants
                new NinjaModel { FirstName = "Chris", LastName = "Ross" }
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            //Accounts accountProcessor = new Accounts(); //Don't need this anymore 

            foreach (var person in applicants)
            {
                //employees.Add(accountProcessor.Create(person));
                employees.Add(person.AccountProcesser.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName }: " + "\n" +
                    $" -- { emp.EmailAddress }" + "\n" +
                    $" -- IsManager: { emp.IsManager }" + "\n" +
                    $" -- IsExecutive: { emp.IsExecutive }" + "\n" +
                    $" -- IsCopro_Assassin {emp.IsCorpo_Assassin}");
            }

            Console.ReadLine();
        }
    }
}
