using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Projekt.Models.Interfaces
{
    public interface IPersonenService
    {
        List<Person> GetPersonen();
        List<Person> GetPersonen(int amount);
    }
}
