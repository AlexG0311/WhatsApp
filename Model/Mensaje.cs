using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WhastApp.Model
{
   public class Mensaje
    {
        public string Imagen { get; set; }
        public string Nombre { get; set; }
        public string remitente { get; set; }
        public string usuario { get; set; }

        public ContentPage Page { get; set; }

        
    }
}
