using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyTutorial2_6
{
    public class Person
    { 
        public Person() { }
        public Person(string name) { this.Name = name; }
        public Person(int id, string name) { this.Id = id; this.Name = name; }
        public int Id;
        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);

        }
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var person = Person.Parse("John"); 
            person.Introduce("Mosh");
            Console.ReadKey();
        }
    }
}
