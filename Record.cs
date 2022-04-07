using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zapis_app
{
    public class Record
    {
        public int Id { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Bydliste { get; set; }
        public string DatumNarozeni { get; set; }
        public string Skola { get; set; }


        public Record(int Id, string Jmeno, string Prijmeni, string Bydliste, string DatumNarozeni, string Skola)
        {
            this.Id = Id;
            this.Jmeno = Jmeno;
            this.Prijmeni = Prijmeni;
            this.Bydliste = Bydliste;
            this.DatumNarozeni = DatumNarozeni;
            this.Skola = Skola;
        }

        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3};{4}", Id, Jmeno, Prijmeni, Bydliste, DatumNarozeni, Skola);
        }

    }
}
