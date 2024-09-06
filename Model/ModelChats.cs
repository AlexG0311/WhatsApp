using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhastApp.Model
{
    public class ModelChats
    {

        public string Nombre { get; set; }
        public string UltimoMensaje { get; set; }
        public string Hora { get; set; }
        public string Imagen { get; set; }
        public string remitente { get; set; }
        public string usuario { get; set; }

        public ContentPage Page { get; set; }
    }
}
