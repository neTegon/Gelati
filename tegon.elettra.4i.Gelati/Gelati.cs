using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tegon.elettra._4i.Gelati
{
    public class Gelati
    {
       private List<Gelato> list;
       public Gelati(string nomeFile)
        {
            StreamReader sr = new StreamReader(nomeFile);
            while (sr.EndOfStream)
            {
                
                list.Add(new Gelato(sr.ReadLine()));
            }
       }
    }
}
