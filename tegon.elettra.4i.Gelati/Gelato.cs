using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tegon.elettra._4i.Gelati
{
    public class Gelato
    {
        private int id { get; set; }
        private string name { get; set; }
        private string description { get; set; }
        private double prezzo { get; set; }
        public Gelati(string riga)
        {
            string[] campi = riga.Split(';');
            this.id = Convert.ToInt32(campi[0]);
            this.name = campi[1];
            this.description = campi[2];
            this.prezzo = Convert.ToDouble(campi[3]);
        }
    }
}
