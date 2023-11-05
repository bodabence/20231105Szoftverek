using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231105Szoftverek
{
    internal class Szoftverek
    {
        public int Azonosito { get; set; }
        public string NevEsVerzio { get; set; }
        public string licenc { get; set; }
        public string Oprendszer { get; set; }
        public string Kategoria { get; set; }
        public double Ertekeles { get; set; }
        public double NettoAr { get; set; }
        public int Adokulcs { get; set; }
        public double BruttoAr;
        public Szoftverek(string sor)
        {
            var v = sor.Split("|");
            this.Azonosito = int.Parse(v[0]);
            this.NevEsVerzio = v[1];
            this.licenc = v[2];
            this.Oprendszer = v[3];
            this.Kategoria = v[4];
            this.Ertekeles = double.Parse(v[5]);
            this.NettoAr = double.Parse(v[6]);
            this.Adokulcs = int.Parse(v[7]);
            this.BruttoAr = this.NettoAr + this.NettoAr * this.Adokulcs / 100;
        }
        public override string ToString()
        {
            return $"Azonosito: {this.Azonosito} | Név és verzió: {this.NevEsVerzio} | Licenc Típusa : {this.licenc} | Operációs rendszer: {this.Oprendszer} | Kategória: {this.Kategoria} | Értékelés: {this.Ertekeles} | Nettó Ár (USD): {this.NettoAr} | Adókulcs: {this.Adokulcs}%";
        }
    }
}
