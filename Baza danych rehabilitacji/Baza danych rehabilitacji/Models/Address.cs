using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza_danych_rehabilitacji.Models
{
    public class Address:Person
    {
        public string Street { get; set; }
        public string StreetNo { get; set; }
        public string PostalCode { get; set; }
        public string Town { get; set; }
        

        public override string ToString()
        {
            return "ul. " + Street + " " + StreetNo + ", " + PostalCode + " " + Town;
        }
    }
}
