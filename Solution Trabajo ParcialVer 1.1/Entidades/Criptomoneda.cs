using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Criptomoneda
    {
        public int idCriptomoneda { get; set; }
        public String Nombre { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Valor { get; set; }
        public int idCreador { get; set; }
        public decimal InversionSeguridad { get; set; }
        public decimal InversionPublicidad { get; set; }
        public int Status { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }
    }
}
