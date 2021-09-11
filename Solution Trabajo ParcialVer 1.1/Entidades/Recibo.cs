using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Recibo
    {
        public int idEmisor { get; set; }
        public string NombreEmisor { get; set; }
        public int idDestinatario { get; set; }
        public string NombreDestinantario { get; set; }
        public String Motivo { get; set; }
        public decimal Cantidad { get; set; }
        public string NombreCriptomoneda { get; set; }


    }
}
