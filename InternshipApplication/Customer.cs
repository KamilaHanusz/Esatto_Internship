using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipApplication
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string VAT_nr { get; set; }
        public DateTime Creation_date { get; }
        public string Address { get; set; }

        public Customer(string name, string surname, string vat_nr, string address)
        {
            Name = name;
            Surname = surname;
            VAT_nr = vat_nr;
            Creation_date = DateTime.Today;
            Address = address;
        }
    }
}
