using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class nRecibo
    {
        dRecibo reciboDao;
        public nRecibo()
        {
            reciboDao = new dRecibo();
        }
        public string InsertarRecibo(Recibo recibo)
        {
            return reciboDao.Insertar(recibo);
        }
        public List<Recibo>ListarRecibosCreador(int idCreador)
        {
            return reciboDao.ListarReciboDelCreador(idCreador);
        }
        public List<Recibo> ListarDestinatarioDelCreador(int idDestinanatario)
        {
            return reciboDao.ListarDestinatarioDelCreador(idDestinanatario);
        }

    }
}
