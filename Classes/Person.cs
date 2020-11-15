using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentleForm.Classes
{
    abstract class Person : Document
    {
        public string Gender { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Gsm { get; set; }
        public Location Address { get; set; }


        public Person(string ID, string Gender, string Name, string Surname, string Email, string Gsm) : base(ID)
        {
            this.Gender = Gender;
            this.Name = Name;
            this.Surname = Surname;
            this.Email = Email;
            this.Gsm = Gsm;
        }
    }
}
