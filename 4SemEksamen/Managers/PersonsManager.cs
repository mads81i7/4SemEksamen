using _4SemEksamen.Models;
using System.Collections.Generic;

namespace _4SemEksamen.Managers
{
    public class PersonsManager
    {
        private static int _nextId = 0;
        private static List<Person> _persons = new List<Person>()
        {
            new Person() { Id = _nextId++, Name = "Gertrud", PhoneNumber = "10 20 30 40"},
            new Person() { Id = _nextId++, Name = "Frederik", PhoneNumber = "50 60 70 80"},
            new Person() { Id = _nextId++, Name = "Hans", PhoneNumber = "90 10 20 30"}
        };
        
        public List<Person> GetAll()
        {
            return _persons;
        }

        //Tilføj exceptions senere
        public Person GetById(int id)
        {
            Person person = _persons.Find(p => p.Id == id);
            return person;
        }

        public void Add(Person person)
        {
            person.Id = _nextId++;
            _persons.Add(person);
        }

        public void Update(int id, Person updates)
        {
            Person person = GetById(id);
            person.Name = updates.Name;
            person.PhoneNumber = updates.PhoneNumber;
        }

        public void Delete(int id)
        {
            Person person = GetById(id);
            _persons.Remove(person);
        }
    }
}
