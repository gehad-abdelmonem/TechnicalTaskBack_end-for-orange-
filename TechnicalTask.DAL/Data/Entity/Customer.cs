using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTask.DAL.Data.Entity
{
    public class Customer
    {
       
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string Service { get; set; } = string.Empty;
        public DateTime ContractDate { get; set; }
        public DateTime ContractExpiryDate { get; set; }

    }
}
