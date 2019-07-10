using System;
using System.Collections.Generic;
using System.Text;

namespace ppedv.NorthwindAgent.Domain.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Delete(T item);
        void Update(T item);
        T FindByID(int id);
        IEnumerable<T> GetAll();
        void SaveChanges();
    }
}
