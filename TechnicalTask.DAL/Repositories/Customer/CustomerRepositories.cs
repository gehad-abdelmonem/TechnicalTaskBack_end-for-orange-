using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTask.DAL.Data.Context;
using TechnicalTask.DAL.Data.Entity;

namespace TechnicalTask.DAL.Repositories
{
    public class CustomerRepositories : ICustomerRepositories
    {
        private readonly SWTaskContext _context;
       public CustomerRepositories(SWTaskContext context) 
        {
            _context = context;   
        }

        public Task<List<Customer>> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Customer>> GetCustomerExpiaryContract()
        {
            return await _context.customers.Where(c => c.ContractExpiryDate < DateTime.Now).AsNoTracking().ToListAsync();
        }

        public async Task<List<Customer>> GetExpireAfter1month()
        {
            return await _context.customers
                .Where(c => c.ContractExpiryDate == DateTime.Now.AddMonths(1))
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<IQueryable<Customer>> GetQuerableCustomers()
        {
            IQueryable<Customer> query = _context.customers.AsNoTracking();
            return query;
        }
    }
}
