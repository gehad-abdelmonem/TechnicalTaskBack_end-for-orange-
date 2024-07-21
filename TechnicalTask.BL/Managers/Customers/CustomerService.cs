using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTask.BL.DTO;
using TechnicalTask.BL.Helpers;
using TechnicalTask.DAL.Data.Entity;
using TechnicalTask.DAL.Repositories;

namespace TechnicalTask.BL.Managers.Customers
{
    public class CustomerService : ICustomerservice
    {
        private readonly ICustomerRepositories _customerRepositories;
        private readonly IMapper _mapper;
        public CustomerService(ICustomerRepositories customerRepositories,IMapper mapper)
        {
            _customerRepositories= customerRepositories;
            _mapper= mapper;
        }
        public async Task<PagedCollectionResponse<ReadCustomerDto>> Get(CustomerParams customerParams)
        {
            IQueryable<Customer> query =await _customerRepositories.GetQuerableCustomers();
            var itemCount = query.Count();
            int skipedCustomers = (customerParams.PageNumber - 1) * customerParams.PageSize;
            var data= await query.Skip(skipedCustomers).Take(customerParams.PageSize).ToListAsync();

            return new PagedCollectionResponse<ReadCustomerDto>
            {
                PageNumber = customerParams.PageNumber,
                PageSize = customerParams.PageSize,
                Count=itemCount,
                Data = _mapper.Map<List<ReadCustomerDto>>(data)
            };
        }

        public async Task<List<ReadCustomerDto>> GetCustomerExpiaryContract()
        {
            var data =await _customerRepositories.GetCustomerExpiaryContract();
            return _mapper.Map<List<ReadCustomerDto>>(data);
        }

        public async Task<List<ReadCustomerDto>> GetExpireAfter1month()
        {
            var data = await _customerRepositories.GetExpireAfter1month();
            return _mapper.Map<List<ReadCustomerDto>>(data);
        }

        public async Task<List<ServiceTypeCustomerCountDto>> GetServiceTypeCustomerCount()
        {
            IQueryable<Customer> dataFromDb =await _customerRepositories.GetQuerableCustomers();
            return await dataFromDb
                .GroupBy(c=>c.Service)
                .Select(g=>new ServiceTypeCustomerCountDto
                {
                    ServiceType=g.Key,
                    CustomerCount=g.Count()
                }).ToListAsync();
                
        }
    }
}
