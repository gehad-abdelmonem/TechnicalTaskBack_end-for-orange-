using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTask.BL.DTO
{
    public class ReadCustomerDto
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string Service { get; set; } = string.Empty;
        public DateTime ContractDate { get; set; }
        public DateTime ContractExpiryDate { get; set; }
    }
}
