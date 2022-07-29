using System;


namespace Evidence_Pojistenych_Remis
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Pojistovna pojistovna = new Pojistovna();
            
            char volba = '0';
            //ať jsou tam rovnou nějaká data
            pojistovna.PridatPojistence("Juan", "Pablo", 321456987, "1.7.1991");
            pojistovna.PridatPojistence("Bohumil", "Hrabal", 123456789, "28.3.1914");
            pojistovna.PridatPojistence("Arnošt", "Skočdopole", 987654321, "1.7.1981");
            pojistovna.PridatPojistence("Jiřina", "Bohdalová", 852147963, "3.5.1931");
            pojistovna.PridatPojistence("Dimitrij", "Dlouhoujmeňák", 147654258, "1.7.1991");
            pojistovna.PridatPojistence("Václav", "Novák", 602789125, "1.7.1939");
            pojistovna.PridatPojistence("Václav", "Novák", 602789135, "1.8.1951");
            pojistovna.PridatPojistence("Václav", "Novák", 602789145, "1.9.1971");
            pojistovna.PridatPojistence("Václav", "Novák", 602789155, "1.10.1991");
            pojistovna.PridatPojistence("Václav", "Novák", 602789165, "1.11.2002");
            pojistovna.PridatPojistence("Václav", "Novák", 602789175, "1.1.2022");

            while (volba != '4')
            {
                pojistovna.VypisHlavni();
                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (volba)
                {
                    case '1':
                        pojistovna.PridatPojistence();
                        break;
                    case '2':
                        pojistovna.VypisPojistencu();
                        break;
                    case '3':
                        pojistovna.NajdiPojistence();
                        break;
                    case '4':
                        Console.WriteLine("Program bude ukončen.");
                        break;
                    default:
                        Console.WriteLine("Neplatná volba, stiskem libovolné klávesy se vrátíte a můžete opakovat volbu.");
                        break;
                }
                Console.WriteLine("\nPokračujte stiskem libovolné klávesy");
                Console.ReadKey();
            }
            Console.WriteLine("Dalším stiskem klávesy dojde k ukočení programu.");
            Console.ReadKey();
        }
    }
}
