using RentleForm.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentleForm
{
    class Guarantor : Person
    {


        public Guarantor(string ID,string Gender, string Name, string Surname, string Email, string Gsm)
            : base(ID, Gender, Name, Surname, Email, Gsm)
        {

        }
        
    }
}
