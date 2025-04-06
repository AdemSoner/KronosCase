using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public string Adress { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CustomerId { get; set; }
        public string CargoCompany { get; set; }
        public List<string> Products { get; set; }

    }
}
