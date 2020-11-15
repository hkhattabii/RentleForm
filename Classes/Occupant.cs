using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentleForm.Classes
{
    class Occupant : Person
    {
        public string NationalRegistry { get; set; }
        public DateTime BirthDate { get; set; }
        public string GuarantorID { get; set; }

        public Occupant(string ID, string Gender, string Name, string Surname, string Email, string Gsm, string NationalRegistry, DateTime BirthDate, string GuarantorID)
            : base(ID,Gender, Name, Surname, Email, Gsm)
        {
            this.NationalRegistry = NationalRegistry;
            this.BirthDate = BirthDate;
            this.GuarantorID = GuarantorID;
        }
    }
}
