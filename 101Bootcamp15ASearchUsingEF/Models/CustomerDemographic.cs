using System;
using System.Collections.Generic;

namespace _101Bootcamp15ASearchUsingEF.Models
{
    public partial class CustomerDemographic
    {
        public CustomerDemographic()
        {
            Customers = new HashSet<Customer>();
        }

        public string CustomerTypeId { get; set; }
        public string CustomerDesc { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
