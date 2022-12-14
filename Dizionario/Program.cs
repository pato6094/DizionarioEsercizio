using System;
using System.Collections.Generic;

namespace Dizionario
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Cittadino c1 = new Cittadino("MREIO20939LSK");
            Dictionary<string, Dictionary<DIP, List<string>>> ANA = new Dictionary<string, Dictionary<DIP, List<string>>>();

            ANA.Add(c1.CF, new());
            ANA[c1.CF].Add(DIP.ASL, new());
            ANA[c1.CF].Add(DIP.COMUNE, new());
            ANA[c1.CF].Add(DIP.POLIZIA, new());
            ANA[c1.CF].Add(DIP.INPS, new());
            ANA[c1.CF].Add(DIP.SCUOLA, new());

            ANA[c1.CF][DIP.ASL].Add("\nMedico di base assegnato: Mario Verdi");
            ANA[c1.CF][DIP.COMUNE].Add("Residente in: via roma 123, Roma, Cap 00100");
            ANA[c1.CF][DIP.POLIZIA].Add("Fedina Penale Pulita");
            ANA[c1.CF][DIP.INPS].Add("Lavoratore,Dipendente,Operaio");
            
            ANA[c1.CF][DIP.SCUOLA].Add("Diploma Superiore");
            
            while (true)
            {
                Console.WriteLine($"\nCittadino corrente {c1.CF} \nSelzionare il numero \n 1.ASL \n 2.COMUNE \n 3.Polizia \n 4.INPS \n 5.SCUOLA\n ");
                string x = Console.ReadLine();

                if(int.Parse(x) == 1)
                {
                    foreach(var item in ANA[c1.CF][DIP.ASL])
                    {
                        Console.WriteLine(item);

                    }

                    
                   
                }
                else if (int.Parse(x) == 2)
                {
                    foreach (var item in ANA[c1.CF][DIP.COMUNE])
                    {
                        Console.WriteLine(item);

                    }
                }

                else if (int.Parse(x) == 3)
                {
                    foreach (var item in ANA[c1.CF][DIP.POLIZIA])
                    {
                        Console.WriteLine(item);

                    }
                }
                else if (int.Parse(x) == 4)
                {
                    foreach (var item in ANA[c1.CF][DIP.INPS])
                    {
                        Console.WriteLine(item);

                    }
                }
                else if (int.Parse(x) == 5)
                {
                    foreach (var item in ANA[c1.CF][DIP.SCUOLA])
                    {
                        Console.WriteLine(item);

                    }
                }






            }




        }
         public enum DIP
        {
            ASL,
            COMUNE,
            POLIZIA,
            INPS,
            SCUOLA
        }
    }
}