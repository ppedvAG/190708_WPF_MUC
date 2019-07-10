using ppedv.NorthwindAgent.Data.EF;
using ppedv.NorthwindAgent.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppedv.NorthwindAgent.UI.Konsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Core core = new Core(new EFRepository(new EFContext()));

            var result = core.GetAllCustomersWithName("A");

            foreach (var item in result)
            {
                Console.WriteLine($"{item.CompanyName}: {item.ContactTitle}");
            }

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
