using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
        public List<Email> Emails { get; set; }
    }
}
