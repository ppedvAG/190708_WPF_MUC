using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLightDemo.Model
{

    class PersonenService : IPersonenService
    {
        public List<Person> GetPersonen()
        {
            return new List<Person>
            {
                new Person{Vorname="Tom",Nachname="Ate",Alter=10,Kontostand=100},
                new Person{Vorname="Anna",Nachname="Nass",Alter=20,Kontostand=11},
                new Person{Vorname="Peter",Nachname="Silie",Alter=30,Kontostand=22343},
                new Person{Vorname="Franz",Nachname="Ose",Alter=40,Kontostand=99},
                new Person{Vorname="Martha",Nachname="Pfahl",Alter=50,Kontostand=1231313},
                new Person{Vorname="Klara",Nachname="Fall",Alter=60,Kontostand=9},
                new Person{Vorname="Rainer",Nachname="Zufall",Alter=70,Kontostand=0987},
                new Person{Vorname="Anna",Nachname="Bolika",Alter=80,Kontostand=123123},
                new Person{Vorname="Albert",Nachname="Tross",Alter=90,Kontostand =-123213},
                new Person{Vorname="Axel",Nachname="Schweiß",Alter=100,Kontostand=123123 } ,
            };
        }
    }
}
