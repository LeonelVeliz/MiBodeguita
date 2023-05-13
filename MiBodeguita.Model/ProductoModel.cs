using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBodeguita.Model
{
    /*
        Los Valores Numericos inicializan en Cero
         mientras q el string inicializa en vacio
     */
    public class ProductoModel
    {
        public int ID { set; get; } 
        public string Nombre { set; get; }
        public decimal PCompra { set; get; } 
        public decimal PVenta { set; get; }
        public decimal Stock { set; get; }
        public int ID_Unidad { set; get; }

        public ProductoModel() {
            Nombre = "Sin Nombre";
            ID_Unidad = Help.Variables.UUnidad;
        }
    }
}
