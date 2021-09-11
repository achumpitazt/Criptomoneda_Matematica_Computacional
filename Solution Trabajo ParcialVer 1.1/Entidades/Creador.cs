using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Creador
    {
        public int idCreador { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Contraseña { get; set; }
        public String Email { get; set; }
        public int CodigoEspecial { get; set; }
        public decimal Inversion { get; set; }
        public decimal Retiro { get; set; }
        public int NumeroTransacciones { get; set; }
        public String TipoCpu { get; set; }
        public int TipoRam { get; set; }
        public String TipoTarjetaGrafica { get; set; }
        public int TiempoConexion { get; set; }
        
    }
}
