using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment2.Models
{
    // Id, Number, Type
    public class PhoneNumber
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Type { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}