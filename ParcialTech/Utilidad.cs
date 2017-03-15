using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParcialTech
{
    public class Utilidad
    {
        public static int ToInt(string texto)
        {
            int numero = 0;
            int.TryParse(texto, out numero);
            return numero;
        }

        public static double ToDouble(string texto)
        {
            double numero = 0;
            double.TryParse(texto, out numero);
            return numero;
        }
    }
}
