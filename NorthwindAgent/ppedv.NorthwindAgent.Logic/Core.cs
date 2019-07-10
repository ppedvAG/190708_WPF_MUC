using ppedv.NorthwindAgent.Domain;
using ppedv.NorthwindAgent.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ppedv.NorthwindAgent.Logic
{
    public class Core
    {
        public Core(IRepository<Customer> customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        private readonly IRepository<Customer> customerRepository;

        public List<Customer> GetAllCustomersWithName(string name)
        {
           return customerRepository.GetAll()
                                    .Where(x => x.CompanyName.StartsWith(name))
                                    .ToList();
        }
    }
}
