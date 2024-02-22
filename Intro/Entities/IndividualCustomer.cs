using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Entities
{
    public class IndividualCustomer:BaseCustomer
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }

    }
    public class CorporateCustomer:BaseCustomer
    {

        public string Name { get; set; }
        public string TaxNumber { get; set; }
    }
    public class BaseCustomer
    { 
        public int Id { get; set; }
        public string CustomerNumber { get; set; }

    }
}
