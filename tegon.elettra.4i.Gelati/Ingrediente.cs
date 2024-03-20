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
        private string calorie { get; set; }
        private string lattosio { get; set; }
        private string colorante { get; set; }
        public Ingrediente(string riga)
        {
            string[] campi = riga.Split(';');
            this.idGelati = Convert.ToInt32(campi[0]);
            this.Tipo = campi[1];
            this.Valore = campi[2];
            if(Tipo=="colorante")
            {
                this.colorante = campi[3];
            }
            else if(Tipo=="Panna")
            {
                this.calorie = campi[3];
            }
            else if(Tipo=="Latte")
            {
                this.lattosio = campi[3];
            }
        }
    }
}
