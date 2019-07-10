using ppedv.NorthwindAgent.Domain;
using ppedv.NorthwindAgent.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ppedv.NorthwindAgent.Data.EF
{
    public class EFRepository : IRepository<Customer>
    {
        public EFRepository(EFContext context)
        {
            this.context = context;
        }
        private readonly EFContext context;


        public void Add(Customer item)
        {
            context.Customer.Add(item);
        }

        public void Delete(Customer item)
        {
            context.Customer.Remove(item);
        }

        public Customer FindByID(string id)
        {
            return context.Customer.FirstOrDefault(x => x.CustomerID == id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return context.Customer.ToList();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(Customer item)
        {
            var loaded = FindByID(item.CustomerID);
            if (loaded != null)
                context.Entry(loaded).CurrentValues.SetValues(item); 
        }
    }
}
