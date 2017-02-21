using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza_danych_rehabilitacji.Models
{
    public class Patient
    {
        public List<Models.PatientAdress> PatientAdress = new List<Models.PatientAdress>();
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pesel { get; set; }
        public string InsuranceNo { get; set; }
        public string InsuranceDate { get; set; }
        public string Insurer { get; set; }
        public string Entitlement { get; set; }

    }
}
