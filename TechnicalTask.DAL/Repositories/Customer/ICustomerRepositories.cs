using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTask.DAL.Data.Entity;
namespace TechnicalTask.DAL.Repositories
{
    public interface ICustomerRepositories
    {
        Task<IQueryable<Customer>> GetQuerableCustomers();
        Task<List<Customer>> GetCustomerExpiaryContract();
        Task<List<Customer>> GetAllCustomers();
        Task<List<Customer>> GetExpireAfter1month();
    }
}
