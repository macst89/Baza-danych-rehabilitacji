using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza_danych_rehabilitacji.Models
{
    public class PatientList
    {
        private List<Patient> _patients;
        List<Patient> patients = new List<Patient>();
        public List<Patient> Patients { get { return _patients; } }
    }
}
