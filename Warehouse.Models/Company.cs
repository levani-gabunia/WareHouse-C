using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Models
{
   public class Company
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string TaxCode { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public string ContactTitle { get; set; }
        public string ContactPhone { get; set; }
        public string Email { get; set; }
        public string Head { get; set; }
        public string Description { get; set; }
    }
}
