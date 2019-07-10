using ppedv.NorthwindAgent.Domain;
using System;
using System.Data.Entity;

namespace ppedv.NorthwindAgent.Data.EF
{
    public class EFContext : DbContext
    {
        public EFContext() : this(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true") {}
        public EFContext(string connectionString) : base(connectionString){}

        public DbSet<Customer> Customer { get; set; }
    }
}
