using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assignment2.Interfaces;
using assignment2.Models;

namespace assignment2.Repositories
{


    public class PersonRepository : IPersonRepository
    {
        private readonly Assignment2DbContext _dbContext;

        public PersonRepository(Assignment2DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Person person)
        {
            _dbContext.Person.Add(person);
            _dbContext.SaveChanges();
        }
        public void ChangeAddress(int personId, Address newAddress)
        {
            var person = _dbContext.Person.FirstOrDefault(p => p.Id == personId);
            if (person == null)
            {
                throw new Exception($"Person with ID {personId} not found.");
            }
            person.Address = newAddress;
            _dbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            var person = _dbContext.Person.FirstOrDefault(p => p.Id == id);
            if (person == null)
            {
                throw new Exception($"Person with ID {id} not found.");
            }
            _dbContext.Person.Remove(person);
            _dbContext.SaveChanges();
        }
        public void DeletePhoneNumbers(int personId)
        {
            var person = _dbContext.Person.FirstOrDefault(p => p.Id == personId);
            if (person == null)
            {
                throw new Exception($"Person with ID {personId} not found.");
            }
            person.PhoneNumbers.Clear();
            _dbContext.SaveChanges();
        }
        public IEnumerable<Person> GetAdults()
        {
            return _dbContext.Person.Where(p => p.DateOfBirth.Year >= 18);
        }
        public IEnumerable<Person> GetAll()
        {
            return _dbContext.Person.ToList();
        }
        public Person GetById(int id)
        {
            var person = _dbContext.Person.FirstOrDefault(p => p.Id == id);
            if (person == null)
            {
                throw new Exception($"Person with ID {id} not found.");
            }
            return person;
        }

        public Person GetPersonByEmail(string email)
        {
            return _dbContext.Person.FirstOrDefault(p => p.Emails.Any(e => e.EmailAddress == email));
        }
        public IEnumerable<Person> GetPersonsByAddress(string address)
        {
            return _dbContext.Person.Where(p => p.Address.Street == address).ToList();
        }

        public IEnumerable<Person> SearchPersonsByName(string name)
        {
            var persons = _dbContext.Person.Where(p => p.Firstname.Contains(name) || p.LastName.Contains(name)).ToList();
            if (persons == null || persons.Count == 0)
            {
                throw new Exception("No persons found with the specified name.");
            }
            return persons;
        }

        public Person Update(Person item)
        {
            var existingPerson = _dbContext.Person.FirstOrDefault(p => p.Id == item.Id);
            if (existingPerson == null)
            {
                throw new Exception($"Person with ID {item.Id} not found.");
            }

            existingPerson.Firstname = item.Firstname;
            existingPerson.LastName = item.LastName;
            existingPerson.DateOfBirth = item.DateOfBirth;
            existingPerson.Gender = item.Gender;
            existingPerson.Address = item.Address;
            existingPerson.PhoneNumbers = item.PhoneNumbers;
            existingPerson.Emails = item.Emails;
            existingPerson.PersonEvents = item.PersonEvents;
            _dbContext.SaveChanges();

            return existingPerson;
        }
    }
}