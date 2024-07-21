using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTask.BL.DTO;
using TechnicalTask.DAL.Data.Entity;

namespace TechnicalTask.BL.Helpers
{
    public class AutoMappingProfile:Profile
    {
        public AutoMappingProfile()
        {
            CreateMap<Customer, ReadCustomerDto>();
        }
    }
}
