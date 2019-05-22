using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUebung
{
    class Persons
    {
        public class Person
        {
            public string Name;
            public string Vorname;
            public string Nachname;
            public int Alter;

            public Person()
            {

            }
            public Person(string vorname, string nachname)
            {
                Vorname = vorname;
                Nachname = nachname;
                Name = vorname + nachname;
            }
            public override string ToString()
            {
                return Name + Alter;
            }
        }
        public class Arzt : Person
        {
            public string Spezialisierung;
            public int Postleitzahl;
            public string Adresse;
            public Arzt (string vorname, string nachname) : base(vorname, nachname)
            {               
            }
        }
        public class Handwerker : Person
        {
            public string Spezialisierung;
            public int Postleitzahl;
            public int Reichweite;

            public Handwerker(string vorname, string nachname) : base(vorname, nachname)
            {
            }
        }
        public class Gaertner : Person
        {
            public int Postleitzahl;
            public int Reichweite;

            public Gaertner(string vorname, string nachname) : base(vorname, nachname)
            {
            }
        }

    }
}
