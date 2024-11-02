using Business.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager
    {
     
        private IApplicantService _applicantservice;

        public PttManager(IApplicantService applicantService) //Constructor new yapıldıgında calisir
        {
            _applicantservice = applicantService;

        }

        public void GiveMask(Person person)
        {
            PersonManager personManager = new PersonManager();
            if (personManager.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " icin maske verildi");
            } 
        }
    }
}
//sonar cube