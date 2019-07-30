using System.Collections.Generic;

namespace NorthwindMigrationRepro.Models
{
    public partial class CustomerDemographics
    {
        public CustomerDemographics()
        {
            CustomerCustomerDemo = new HashSet<CustomerDemo>();
        }

        public string CustomerTypeId { get; set; }
        public string CustomerDesc { get; set; }

        public virtual ICollection<CustomerDemo> CustomerCustomerDemo { get; set; }
    }
}
