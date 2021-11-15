using System;
using System.Collections.Generic;
using System.Linq;

namespace Prueba1
{
    class Program
    {
        static void Main(string[] args)
        {

            trans("asdlkf", "uppercase->lowercase->manana");
        }

        public static string trans(string palabra, string stransformacion) 
        {
            string[] transformacion = stransformacion.Split("->");
            List<string> transformacionToLower = new List<string>();
            List<string> palabrasConvertidas = new List<string>();
            string convertida = "";

            foreach (var item in transformacion)
            {
                transformacionToLower.Add(item.ToLower());
            }
            /* foreach (var item in transformacionToLower)
             {

             }*/
            if (transformacionToLower.Contains("uppercase"))
            {
                for (int i = 0; i < palabra.Length; i++)
                {
                    if (palabra[i] >= 'a' && palabra[i] <= 'z')
                    {
                        convertida += (char)(palabra[i] - 'a' + 'A');
                    }
                    else
                    {
                        convertida += palabra[i];
                    }
                }

                palabrasConvertidas.Add(convertida);

            }
            if (transformacionToLower.Contains("lowercase"))
            {
                string convertida2= "";
                for (int i = 0; i < convertida.Length; i++)
                {
                    if (convertida[i] >= 'A' && convertida[i] <= 'Z')
                    {
                        convertida2 += (char)(convertida[i] - 'A' + 'a');
                    }
                    else
                    {
                        convertida2 += convertida[i];
                    }
                }

                palabrasConvertidas.Add(convertida2);
            }

            foreach (var item in palabrasConvertidas)
            {
                string convertida2 = item;
                Console.WriteLine(convertida2);
            }

            return "" ;
        }
    }
}
