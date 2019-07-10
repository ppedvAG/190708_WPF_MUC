using MVVM_Projekt.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Projekt.Models
{
    public class PersonenService : IPersonenService
    {
        public List<Person> GetPersonen()
        {
            return new List<Person>
            {
                new Person{Vorname="Tom",Nachname="Ate",Alter=10,Kontostand=100,Status=Status.Online,ImageURL="http://lorempixel.com/100/100/people/1"},
                new Person{Vorname="Anna",Nachname="Nass",Alter=20,Kontostand=112300,Status=Status.Online,ImageURL="http://lorempixel.com/100/100/people/2"},
                new Person{Vorname="Peter",Nachname="Silie",Alter=30,Kontostand=-123100,Status=Status.Abwesend,ImageURL="http://lorempixel.com/100/100/people/3"},
                new Person{Vorname="Franz",Nachname="Ose",Alter=40,Kontostand=990,Status=Status.Beschäftigt,ImageURL="http://lorempixel.com/100/100/people/4"},
                new Person{Vorname="Martha",Nachname="Pfahl",Alter=50,Kontostand=-123100,Status=Status.Abwesend,ImageURL="http://lorempixel.com/100/100/people/5"},
                new Person{Vorname="Klara",Nachname="Fall",Alter=60,Kontostand=975100,Status=Status.Offline,ImageURL="http://lorempixel.com/100/100/people/6"},
                new Person{Vorname="Rainer",Nachname="Zufall",Alter=70,Kontostand=0,Status=Status.Beschäftigt,ImageURL="http://lorempixel.com/100/100/people/7"},
                new Person{Vorname="Anna",Nachname="Bolika",Alter=80,Kontostand=123413,Status=Status.Online,ImageURL="http://lorempixel.com/100/100/people/8"},
                new Person{Vorname="Albert",Nachname="Tross",Alter=90,Kontostand=9764,Status=Status.Offline,ImageURL="http://lorempixel.com/100/100/people/9"},
                new Person{Vorname="Axel",Nachname="Schweiß",Alter=100,Kontostand=123,Status=Status.Offline ,ImageURL="http://lorempixel.com/100/100/people/10"},
            };
        }

        public List<Person> GetPersonen(int amount)
        {
            Random generator = new Random();
            List<Person> personen = new List<Person>(); // Performance

            for (int i = 0; i < amount; i++)
            {
                Person p = new Person();
                p.Vorname = Guid.NewGuid().ToString();
                p.Nachname = Guid.NewGuid().ToString();
                p.Alter = (byte)generator.Next(0, 255);
                p.Kontostand = generator.Next(0, Int32.MaxValue);
                p.Status = (Status)generator.Next(0, 4);
                p.ImageURL = $"http://lorempixel.com/100/100/people/{i}";
                personen.Add(p);
            }
            return personen;
        }
    }
}
