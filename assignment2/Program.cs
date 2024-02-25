using System;
using assignment2.ExtensionMethods;
using assignment2.Models;
using assignment2.Repositories;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new Assignment2DbContext();
            var personRepository = new PersonRepository(dbContext);
            var personService = new PersonService(personRepository);
            var person = new Person
            {
                Firstname = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(1990, 1, 1),
                Gender = enums.Gender.Male,
                Address = new Address
                {
                    Street = "123 Main St",
                    City = "Anytown",
                    Zipcode = 12345
                }
            };

            personService.AddPerson(person);

            var retrievedPerson = personService.GetPersonById(person.Id);
            $"Retrieved person: {retrievedPerson.Firstname} {retrievedPerson.LastName}".Log();

            var newAddress = new Address
            {
                Street = "123 Main St",
                City = "dsadsad",
                Zipcode = 3213
            };
            personService.ChangeAddress(person.Id, newAddress);

            personService.DeletePhoneNumbers(person.Id);

            var adults = personService.GetAdults();
            adults.Log("Adults:");

            var personsByAddress = personService.GetPersonsByAddress("123 Main St");
            personsByAddress.Log("Persons by address:");

            var personsByName = personService.SearchPersonsByName("John");
            personsByName.Log("Persons by name:");

            var personByEmail = personService.GetPersonByEmail("john@example.com");
            if (personByEmail != null)
            {
                $"Person by email: {personByEmail.Firstname} {personByEmail.LastName}".Log();
            }
            else
            {
                "No person found with the specified email.".Log();
            }
        }
    }
}