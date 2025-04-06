using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case.Domain.Entities
{
    public class OrderDto
    {
        public string CargoCompany { get; set; }
        public string Adress { get; set; }
        public List<string> Products { get; set; }
    }
}
