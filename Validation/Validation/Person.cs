using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation
{
    class Person
    {
        private string vorname;
        private string nachname;
        private byte alter;
        private decimal kontostand;

        public string Vorname { get => vorname; set => vorname = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public byte Alter { get => alter; set => alter = value; }
        public decimal Kontostand { get => kontostand; set => kontostand = value; }
    }
}
