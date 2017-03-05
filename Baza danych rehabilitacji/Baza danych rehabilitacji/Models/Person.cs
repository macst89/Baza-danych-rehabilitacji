using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza_danych_rehabilitacji.Models
{
    public class Person
    {
        private static DateTime _birthDate;
        private static int _id = 0;
        private int _personId = 0;
        private string _pesel;
        private char _gender;
        public List<Address> personAddress = new List<Address>();
        public List<Address> PersonAddress { get { return personAddress; } }
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pesel { get { return _pesel; } set { _pesel = value; } }
        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                _birthDate = DateTime.Parse("19" + _pesel.Substring(0, 2) + "-" + _pesel.Substring(2, 2) + "-" + _pesel.ToString().Substring(4, 2));
            }
        }
        public char Gender
        {
            get { return _gender; }
            set
            {
                int plec = Convert.ToInt32(_pesel.Substring(9, 1));
                if (plec % 2 != 0)
                {
                    _gender = 'M';
                }
                else
                {
                    _gender = 'K';
                }
            }
        }

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
