using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using MingChi.CRMApplication.CRMs.ViewModels;
using MingChi.Infrastructure.Configuration.CRMs;

namespace MingChi.CRMApplication.CRMs
{
    public class CRM
    {
        private readonly IApplicationDbContext _applicationDbContext;
        private readonly IJsonConfigurationBuilder jsonConfigurationBuilder;

        public CRM(IJsonConfigurationBuilder jsonConfigurationBuilder, IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext; //new ApplicationDbContext(jsonConfigurationBuilder.GetConnectionString());

            this.jsonConfigurationBuilder = jsonConfigurationBuilder;
        }

        public IEnumerable<CustomerViewModel> GetCustomers()
        {
            var result = from cus in _applicationDbContext.Customers
                         select new CustomerViewModel()
                         {
                             CustomerId = cus.CustomerId,
                             ContactName = cus.ContactName,
                             CompanyName = cus.CompanyName,
                             Region = cus.Region,
                             Address = cus.Address,
                             City = cus.City,
                             ContactTitle = cus.ContactTitle,
                             Country = cus.Country,
                             Phone = cus.Phone
                         };

            return result;
        }
    }
}
