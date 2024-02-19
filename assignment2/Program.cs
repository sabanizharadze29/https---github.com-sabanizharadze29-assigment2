using System;
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
                // Add other properties as needed
            };

            personService.AddPerson(person);

            var retrievedPerson = personService.GetPersonById(person.Id);
            Console.WriteLine($"Retrieved person: {retrievedPerson.Firstname} {retrievedPerson.LastName}");

            var newAddress = new Address
            {
                Street = "123 Main St",
                City = "dsadsad",
                Zipcode = 3213
            };
            personService.ChangeAddress(person.Id, newAddress);

            personService.DeletePhoneNumbers(person.Id);

            var adults = personService.GetAdults();
            Console.WriteLine("Adults:");
            foreach (var adult in adults)
            {
                Console.WriteLine($"{adult.Firstname} {adult.LastName}");
            }

            var personsByAddress = personService.GetPersonsByAddress("123 Main St");
            Console.WriteLine("Persons by address:");
            foreach (var personByAddress in personsByAddress)
            {
                Console.WriteLine($"{personByAddress.Firstname} {personByAddress.LastName}");
            }

            var personsByName = personService.SearchPersonsByName("John");
            Console.WriteLine("Persons by name:");
            foreach (var personByName in personsByName)
            {
                Console.WriteLine($"{personByName.Firstname} {personByName.LastName}");
            }

            var personByEmail = personService.GetPersonByEmail("john@example.com");
            if (personByEmail != null)
            {
                Console.WriteLine($"Person by email: {personByEmail.Firstname} {personByEmail.LastName}");
            }
            else
            {
                Console.WriteLine("No person found with the specified email.");
            }
        }
    }
}