using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Evidence_Pojistenych_Remis
{
    internal class Pojistovna
    {
        private List<Pojistenec> pojistenci = new List<Pojistenec>();

        /// <summary>
        /// množství pojištěných - zvýší se vždy, když je přidán nový pojištěnec přes metodu PridatPojistence().
        /// </summary>
        static int pocetPojistenych = 0;

        /// <summary>
        /// vyzve uživatel k zadání pojištěnce a uloží ho do Listu
        /// </summary>
        public void PridatPojistence()
        {
            string jmeno = ZadejJmeno();
            string prijmeni = ZadejPrijmeni();

            Console.WriteLine("Zadejte telefoní číslo (9 číslic):");
            int telefon;
            while (!int.TryParse(Console.ReadLine(), out telefon) || (telefon.ToString().Length != 9)) //aby bylo opravdu číslo a aby mělo 9 čísel
                Console.WriteLine("Neplatné zadání, zadejte 9 číslic telefonního čísla.");

            Console.WriteLine("Zadejte datum narození:");
            DateTime datumNarozeni;
            while (!DateTime.TryParse(Console.ReadLine(), out datumNarozeni))
                Console.WriteLine("Zadejte datum narození, například ve formátu: \"dd.mm.rrrr\"");

            pojistenci.Add(new Pojistenec(jmeno, prijmeni, telefon, datumNarozeni));
            Console.WriteLine("\nPřidán pojištenec: \n{0}", pojistenci[pocetPojistenych]);
            pocetPojistenych++;
        }

        /// <summary>
        /// Vyzve k zadání Příjmení
        /// </summary>
        /// <returns>Příjmení</returns>
        public string ZadejPrijmeni()
        {
            Console.WriteLine("Zadejte příjmení:");
            return Console.ReadLine();
        }
        /// <summary>
        /// Vyzve k zadání křestního jména.
        /// </summary>
        /// <returns>Křestní jméno</returns>
        public string ZadejJmeno()
        {
            Console.WriteLine("Zadejte křestní jméno:");
            return Console.ReadLine(); ;
        }

        /// <summary>
        /// Vyhledá pojištěnce podle jména a příjmení
        /// </summary>
        public void NajdiPojistence()
        {
            Console.WriteLine("Vyhledáme pojištěnce podle jména a příjmení: \n");

            string jmeno = ZadejJmeno();
            string prijmeni = ZadejPrijmeni();

            List<Pojistenec> nalezeni = new List<Pojistenec>();

            foreach (Pojistenec p in pojistenci)
            {
                if ((jmeno.Trim().ToLower() == p.Jmeno.Trim().ToLower())&&(prijmeni.Trim().ToLower() == p.Prijmeni.Trim().ToLower()))
                {
                    nalezeni.Add(p);
                }
            }
            if (nalezeni.Count == 1)
                Console.WriteLine("Nalezen tento pojištěnec: \n{0}", nalezeni[0]);
            else if (nalezeni.Count > 1)
            {
                Console.WriteLine("Nalezeni tito pojištěnci: ");
                foreach (Pojistenec n in nalezeni)
                {
                    Console.WriteLine(n);
                }
            }
            else
                Console.WriteLine("Žádný pojištěnec tohoto jména nenalezen.");
        }

        /// <summary>
        /// Vypíše všechny pojištěnce
        /// </summary>
        public void VypisPojistencu()
        {
            Console.WriteLine("Seznam všech pojištěných: ");
            foreach (Pojistenec p in pojistenci)
                Console.WriteLine(p);
        }
        /// <summary>
        /// Vypíše hlavní menu
        /// </summary>
        public void VypisHlavni()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine(@"
  ______     _     _                       _____      _ _     _                _       _     
 |  ____|   (_)   | |                     |  __ \    (_|_)\_/| |  \_/         //      | |    
 | |____   ___  __| | ___ _ __   ___ ___  | |__) |__  _ _ ___| |_ ___ _ __  _   _  ___| |__  
 |  __\ \ / / |/ _` |/ _ \ '_ \ / __/ _ \ |  ___/ _ \| | / __| __/ _ \ '_ \| | | |/ __| '_ \ 
 | |___\ V /| | (_| |  __/ | | | (_|  __/ | |  | (_) | | \__ \ ||  __/ | | | |_| | (__| | | |
 |______\_/ |_|\__,_|\___|_| |_|\___\___| |_|   \___/| |_|___/\__\___|_| |_|\__, |\___|_| |_|
                                                    _/ |                     __/ |           
                                                   |__/                     |___/            
");
            Console.WriteLine("Aktuální počet pojištěných: {0}\n----------------------------------------------------------------------------------------------------", pocetPojistenych);
            Console.WriteLine();
            Console.WriteLine("Vyberte jednu z možností:");
            Console.WriteLine();
            Console.WriteLine("1 - Přidat Pojištěného");
            Console.WriteLine("2 - Výpis všech pojištěných");
            Console.WriteLine("3 - Najít pojištěného");
            Console.WriteLine("4 - Ukončit aplikaci");
        }

        /// <summary>
        /// Přetížení pro přidání DUMMY dat před zahájením programu
        /// </summary>
        /// <param name="jmeno">Jméno</param>
        /// <param name="prijmeni">Příjmení</param>
        /// <param name="telefon">Telefoní číslo</param>
        /// <param name="datum">Datum narození</param>
        public void PridatPojistence(string jmeno, string prijmeni, int telefon, string datum)
        {
            DateTime datumNarozeni = DateTime.Parse(datum);
            
            pojistenci.Add(new Pojistenec(jmeno, prijmeni, telefon, datumNarozeni));
            pocetPojistenych++;
        }
    }
}
