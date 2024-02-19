using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assignment2.enums;
using assignment2.Models;

namespace assignment2.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Address Address { get; set; }
        public ICollection<PhoneNumber> PhoneNumbers { get; set; }
        public ICollection<Email> Emails { get; set; }
        public ICollection<PersonEvent> PersonEvents { get; set; }
    }
}