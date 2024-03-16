using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tegon.elettra._4i.Gelati
{
    public class Ingrediente
    {
        private int idGelati { get; set; }
        private string Tipo { get; set; }
        private string Valore { get; set; }
        public Ingredienti(string riga)
        {
            string[] campi = riga.Split(';');
            this.idGelati = Convert.ToInt32(campi[0]);
            this.Tipo = campi[1];
            this.Valore = campi[2];
        }
    }
}
