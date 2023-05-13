using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBodeguita.Help
{
    public class Variables
    {
        // Unidades
        public static int UUnidad = 1;
        public static int UKilo = 2;
        public static int ULitro = 3;

        public static string getUnidad(int IdUnidad)
        {
            switch (IdUnidad) {
                case 1: return "UNIDAD";
                case 2: return "KILOGRAMO";
                case 3: return "LITRO";
                default: return "-";
            }
        }
    }
}
