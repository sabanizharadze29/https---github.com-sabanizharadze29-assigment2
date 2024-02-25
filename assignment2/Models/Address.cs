using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment2.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }

    }
}