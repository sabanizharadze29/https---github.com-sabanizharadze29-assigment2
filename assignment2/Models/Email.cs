using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace assignment2.Models
{
    // Id, EmailAddress,IsPrimary
    public class Email
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public bool IsPrimary { get; set; }

        public Person Person { get; set; }
        public int PersonId { get; set; }
    }
}