using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assignment2.Models;

namespace assignment2.Interfaces
{

    public interface IPersonRepository : IRepository<Person>
    {
        void ChangeAddress(int personId, Address newAddress);
        void DeletePhoneNumbers(int personId);
        IEnumerable<Person> GetPersonsByAddress(string address);
        Person GetPersonByEmail(string email);
        IEnumerable<Person> SearchPersonsByName(string name);
        IEnumerable<Person> GetAdults();
    }
}