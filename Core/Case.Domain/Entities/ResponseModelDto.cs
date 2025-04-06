using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case.Domain.Entities
{
    public class ResponseModelDto
    {
        public bool status { get; set; }
        public string message { get; set; }
        public object data { get; set; }
    }
}
