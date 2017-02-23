using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza_danych_rehabilitacji.Models
{
    public class Person
    {
        private static int _id = 0;
        private int _personId = 0;
        private List<Address> personAddress = new List<Address>();
        public List<Address> PersonAddress { get { return personAddress; } }
        public int PersonId { get { return _personId; } }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pesel { get; set; }
        public void AddAddress(string street, string streetNo, string town, string postalCode)
        {    
                personAddress.Add(new Address { Street = street, StreetNo = streetNo, PostalCode = postalCode, Town = town });
        }
        public Person()
        {
            _id++;
            this._personId = _id;

        }
       
    }
}
