using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechnicalTask.BL.DTO;
using TechnicalTask.BL.Helpers;
using TechnicalTask.BL.Managers.Customers;

namespace TechnicalTask.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerservice _customerservice;
        public CustomerController(ICustomerservice customerservice)
        {
            _customerservice = customerservice;
        }


        [HttpGet]
        [Route("paginate")]
        public async Task<ActionResult<PagedCollectionResponse<ReadCustomerDto>>> Get([FromQuery] CustomerParams customerParams)
        {
            var result= await _customerservice.Get(customerParams);
            return Ok(result);
        }

        [HttpGet]
        [Route("CustomerWithExpiryContract")]
        public async Task<ActionResult<List<ReadCustomerDto>>> GetCustomerExpiaryContract()
        {
            return await _customerservice.GetCustomerExpiaryContract();
        }

        [HttpGet]
        [Route("ServiceTypeCustomerCount")]
        public async Task<ActionResult<List<ServiceTypeCustomerCountDto>>> GetServiceTypeCount()
        {
            return await _customerservice.GetServiceTypeCustomerCount();
        }
        [HttpGet]
        [Route("ExpireAfter1month")]
        public async Task<ActionResult<List<ReadCustomerDto>>> GetExpireAfter1month()
        {
            return await _customerservice.GetExpireAfter1month();
        }
    }
}

