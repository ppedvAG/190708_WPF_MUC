using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation
{
    class MainViewModel
    {
        public MainViewModel()
        {
            Person = new Person { Vorname = "Tom", Nachname = "Ate", Alter = 10, Kontostand = 100 };
        }
        public Person Person { get; set; }
    }
}
