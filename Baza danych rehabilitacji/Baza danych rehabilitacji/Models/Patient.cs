using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza_danych_rehabilitacji.Models
{
    public class Patient:Person
    {
        
        public string InsuranceNo { get; set; }
        public string InsuranceDate { get; set; }
        public string Insurer { get; set; }
        public string Entitlement { get; set; } //Uprawnienia
        
    }
}
