using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tegon.elettra._4i.Gelati
{
    public class Ingredienti
    {
        private List<Ingrediente> list;
        public Ingredienti(string nomeFile)
        {
            StreamReader sr = new StreamReader(nomeFile);
            while (sr.EndOfStream)
            {

                list.Add(new Ingrediente(sr.ReadLine()));
            }
        }

    }
}
