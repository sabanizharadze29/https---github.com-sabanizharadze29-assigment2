using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assignment2.Interfaces;
using assignment2.Models;

namespace assignment2
{
    public class PersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public void AddPerson(Person person)
        {
            _personRepository.Add(person);
        }

        public void ChangeAddress(int personId, Address newAddress)
        {
            _personRepository.ChangeAddress(personId, newAddress);
        }

        public void DeletePhoneNumbers(int personId)
        {
            _personRepository.DeletePhoneNumbers(personId);
        }

        public IEnumerable<Person> GetAdults()
        {
            return _personRepository.GetAdults();
        }

        public IEnumerable<Person> GetAll()
        {
            return _personRepository.GetAll();
        }

        public Person GetPersonById(int id)
        {
            return _personRepository.GetById(id);
        }

        public Person GetPersonByEmail(string email)
        {
            return _personRepository.GetPersonByEmail(email);
        }

        public IEnumerable<Person> GetPersonsByAddress(string address)
        {
            return _personRepository.GetPersonsByAddress(address);
        }

        public IEnumerable<Person> SearchPersonsByName(string name)
        {
            return _personRepository.SearchPersonsByName(name);
        }
    }
}