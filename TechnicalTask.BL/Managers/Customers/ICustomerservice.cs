using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTask.BL.DTO;
using TechnicalTask.BL.Helpers;

namespace TechnicalTask.BL.Managers.Customers
{
    public interface ICustomerservice
    {
        Task<PagedCollectionResponse<ReadCustomerDto>> Get(CustomerParams customerParams);
        Task<List<ReadCustomerDto>> GetCustomerExpiaryContract();
        Task<List<ServiceTypeCustomerCountDto>> GetServiceTypeCustomerCount();
        Task<List<ReadCustomerDto>> GetExpireAfter1month();

    }
}
