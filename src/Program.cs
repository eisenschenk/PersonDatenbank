using System;

namespace ClassUebung
{
    class Program
    {
        static void CaseDatenBerufe(ConsoleKeyInfo caseSwitchBeruf, ConsoleKeyInfo caseSwitchDaten, int reichweite, int postleitzahl, string spezialisierung, string adresse)
        {
            switch (caseSwitchBeruf.KeyChar)
            {
                case '1':
                    switch (caseSwitchDaten.KeyChar)
                    {
                        case '1':
                            Console.WriteLine("Bitte geben Sie die Reichweite des Unternehmens ein");
                            reichweite = Console.Read();
                            break;
                        case '2':
                            Console.WriteLine("Bitte geben Sie eine Postleitzahl ein.");
                            postleitzahl = Console.Read();
                            break;
                        case '3':
                            Console.WriteLine("Bitte geben Sie eine Spezialisierung ein.");
                            spezialisierung = Console.ReadLine();
                            break;
                    }
                    break;

                case '2':
                    switch (caseSwitchDaten.KeyChar)
                    {
                        case '1':
                            Console.WriteLine("Bitte geben Sie die Reichweite des Unternehmens ein");
                            reichweite = Console.Read();
                            break;
                        case '2':
                            Console.WriteLine("Bitte geben Sie eine Postleitzahl ein.");
                            postleitzahl = Console.Read();
                            break;
                    }
                    break;

                case '3':
                    switch (caseSwitchDaten.KeyChar)
                    {
                        case '1':
                            Console.WriteLine("Bitte geben Sie die Adresse des Unternehmens ein");
                            adresse = Console.ReadLine();
                            break;
                        case '2':
                            Console.WriteLine("Bitte geben Sie eine Postleitzahl ein.");
                            postleitzahl = Console.Read();
                            break;
                        case '3':
                            Console.WriteLine("Bitte geben Sie eine Spezialisierung ein.");
                            spezialisierung = Console.ReadLine();
                            break;
                    }
                    break;
                case 'e':
                    break;
            }
        }
        static void Wahlvornachname(string vorname, string nachname)
        {
            Console.WriteLine("Programm für Datenbank von Personen mit Berufen");
            Console.WriteLine();
            Console.WriteLine("Bitte geben Sie einen Vornamen ein.");
            vorname = Console.ReadLine();
            Console.WriteLine("Bitte geben Sie einen Nachnamen ein.");
            nachname = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------------"); Console.WriteLine();
        }
        static void Wahlberuf()
        {
            Console.WriteLine("Bitte Wählen Sie einen der folgenden Berufe aus."); Console.WriteLine();
            Console.WriteLine("1 - Handwerker");
            Console.WriteLine("2 - Gaertner");
            Console.WriteLine("3 - Arzt");
            Console.WriteLine("e - Exit");
            Console.WriteLine("-------------------------------------------------------"); Console.WriteLine();
            
            Console.WriteLine();
        }
        static void Unterpunkt(ConsoleKeyInfo caseSwitchBeruf)
        {
            Console.WriteLine("Waehlen Sie einen der Unterpunkte aus um ihn mit Daten zu versehen."); Console.WriteLine();
           
            Console.WriteLine();
            switch (caseSwitchBeruf.KeyChar)
            {
                case '1':
                    Console.WriteLine("1 - Reichweite");
                    Console.WriteLine("2 - Postleitzahl");
                    Console.WriteLine("3 - Spezialisierung");
                    break;
                case '2':
                    Console.WriteLine("1 - Reichweite");
                    Console.WriteLine("2 - Postleitzahl");
                    break;
                case '3':
                    Console.WriteLine("1 - Adresse");
                    Console.WriteLine("2 - Postleitzahl");
                    Console.WriteLine("3 - Spezialisierung");
                    break;
                case 'e':
                    break;
            }
            
        }
        static void InDateiSchreiben(ConsoleKeyInfo caseSwitchBeruf, string vorname, string nachname, int postleitzahl, int reichweite, string spezialisierung, string adresse)
        {
            switch (caseSwitchBeruf.KeyChar)
            {
                case '1':
                    Persons.Handwerker handwerker = new Persons.Handwerker(vorname, nachname);
                    handwerker.Postleitzahl = postleitzahl;
                    handwerker.Spezialisierung = spezialisierung;
                    handwerker.Reichweite = reichweite;
                    break;

                case '2':
                    Persons.Gaertner gaertner = new Persons.Gaertner(vorname, nachname);
                    gaertner.Postleitzahl = postleitzahl;
                    gaertner.Reichweite = reichweite;
                    break;

                case '3':
                    Persons.Arzt arzt = new Persons.Arzt(vorname, nachname);
                    arzt.Adresse = adresse;
                    arzt.Spezialisierung = spezialisierung;
                    arzt.Postleitzahl = postleitzahl;
                    break;
                case 'e':
                    Persons.Person person = new Persons.Person(vorname, nachname);
                    break;
            }
        }
        static void WeitereDaten(ConsoleKeyInfo caseSwitchBeruf, ConsoleKeyInfo caseSwitchDaten, int reichweite, int postleitzahl, string spezialisierung, string adresse)
        {
            ConsoleKeyInfo yesno = new ConsoleKeyInfo();
            while (yesno.KeyChar != 'n')
            {
                Console.WriteLine("Möchten Sie weitere Daten hinzufügen bzw. Änderungen vornehmen? y/n");
                Console.WriteLine();
                yesno = Console.ReadKey();
                ConsoleKeyInfo CaseDaten = default;
                switch (yesno.KeyChar)
                {
                    case 'y':
                        Unterpunkt(caseSwitchBeruf);
                        CaseDaten = Console.ReadKey();
                        CaseDatenBerufe(caseSwitchBeruf, CaseDaten, reichweite, postleitzahl, spezialisierung, adresse);
                        break;

                    case 'n':
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo caseSwitchBeruf = default;
            ConsoleKeyInfo caseSwitchDaten = default;
         
            string vorname = null;
            string nachname = null;
            int postleitzahl = 0;
            int reichweite = 0;
            string spezialisierung = null;
            string adresse = null;

            Wahlvornachname(vorname, nachname);
            Wahlberuf();
            caseSwitchBeruf = Console.ReadKey();
            Unterpunkt(caseSwitchBeruf);
            caseSwitchDaten = Console.ReadKey();
            CaseDatenBerufe(caseSwitchBeruf,caseSwitchDaten, reichweite, postleitzahl, spezialisierung,adresse);
           // WeitereDaten(caseSwitchBeruf, caseSwitchDaten, reichweite, postleitzahl,spezialisierung, adresse);
            InDateiSchreiben(caseSwitchBeruf, vorname, nachname, postleitzahl, reichweite, spezialisierung, adresse);

            Console.ReadKey();
        }
    }
}
