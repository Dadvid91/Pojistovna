using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_Pojistenych_Remis
{
    internal class Pojistenec
    {
        /// <summary>
        /// Křestní jméno
        /// </summary>
        public string Jmeno { get; private set; }
        /// <summary>
        /// Příjmnení
        /// </summary>
        public string Prijmeni { get; private set; }
        /// <summary>
        /// Telfoní číslo
        /// </summary>
        public int CisloTel { get; private set; }
        /// <summary>
        /// Datum narození
        /// </summary>
        public DateTime DatumNarozeni { get; private set; }
        /// <summary>
        /// Věk pojištěného
        /// </summary>
        public int Vek { get; private set; }

        /// <summary>
        /// Založení pojištěného
        /// </summary>
        /// <param name="jmeno">Jméno</param>
        /// <param name="prijmeni">Příjmení</param>
        /// <param name="cisloTel">Telefoní číslo</param>
        /// <param name="datumNarozeni">Datum narození -> Věk</param>
        public Pojistenec(string jmeno, string prijmeni, int cisloTel, DateTime datumNarozeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            CisloTel = cisloTel;
            DatumNarozeni = datumNarozeni;
            Vek = SpocitejVek();
        }

        public int SpocitejVek()
        {
            DateTime dnes = DateTime.Today;
            int vek = dnes.Year - DatumNarozeni.Year;
            if (dnes < DatumNarozeni.AddYears(vek))
                vek--;
            return vek;
        }
        public override string ToString()
        {
            return string.Format("{0, -10} | {1, -13} | Tel: {2, -10} | Věk: {3, -3}", Jmeno, Prijmeni, CisloTel, Vek);
        }
    }
}
