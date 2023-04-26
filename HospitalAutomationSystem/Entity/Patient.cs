using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomationSystem.Entity
{
   public class Patient
    {
        public int Id { get; set; }
        public string  Name{ get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
