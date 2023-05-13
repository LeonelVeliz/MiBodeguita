using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBodeguita.Model
{
    public class RespuestaModel
    {
        public int ID { set; get; }
        public string Mensaje { set; get; }
        public bool Error { set; get; }

        public RespuestaModel() {
            Mensaje = "Intente en Otro Momento";
            Error = true;
        }

        public RespuestaModel(int ID, string Mensaje, bool Error) {
            this.ID = ID;
            this.Mensaje = Mensaje;
            this.Error = Error;
        }
    }
}
