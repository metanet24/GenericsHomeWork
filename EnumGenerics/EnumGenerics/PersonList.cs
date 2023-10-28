using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumGenerics
{
    public class PersonList
    {
        private Person[] _persons;

        public PersonList()
        {
            _persons = new Person[0];
        }


        public void Add(Person person)
        {
            Array.Resize(ref _persons, _persons.Length + 1);

            _persons[_persons.Length - 1] = person;
        }

        public void GetAll()
        {
            foreach (Person person in _persons)
            {
                Console.WriteLine(person.Name + " " + person.Surname);
            }
        }
    }
}
