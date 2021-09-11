using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;


namespace Negocio
{
    public class nBilleteraVirtual
    {
        dBilleteraVirtual billeteravirtualDao;
        public nBilleteraVirtual()
        {
            billeteravirtualDao = new dBilleteraVirtual();
        }
        public string Agregar(BilleteraVirtual billeteraVirtual)
        {
            return billeteravirtualDao.Insertar(billeteraVirtual);
        }
        public string Agregar2(int idCreador, string Nombre, decimal Cantidad, int Minado)
        {
            return billeteravirtualDao.Insertar2(idCreador, Nombre, Cantidad, Minado);
        }
        public List<BilleteraVirtual> ListarBilleteraConidCreador(int idcreador)
        {
            return billeteravirtualDao.ListarBillteraConidCreador(idcreador);
        }
        public string ModificarCantidadBillteraVirtual(decimal nuevacantidad, int idCreador, string nombrecriptomoneda)
        {
            return billeteravirtualDao.ModificarCantidadBilltera(nuevacantidad, idCreador, nombrecriptomoneda);
        }
        public decimal BuscarCantidadConidCreadorBilltera(string nombrecriptomoneda, int idCreador)
        {
            return billeteravirtualDao.BuscarCantidadConidCreadorBilltera(nombrecriptomoneda, idCreador);
        }
        public string ModificarMinadoConNombreCriptomoneda(int nuevominado,int idCreador,string nombrecriptomoneda)
        {
            return billeteravirtualDao.ModificarMinadoBilltera(nuevominado,idCreador,nombrecriptomoneda);
        }
        //public string ModificarCantidadBancos(decimal nuevacantidad, string nombrecriptomoneda, int idCreador)
        //{
        //    return billeteravirtualDao.ModificarCantidadBancos(nuevacantidad, nombrecriptomoneda, idCreador);
        //}
        public bool ExisteCriptomonedaEnBilletera(string nombre, int idCreador)
        {
            return billeteravirtualDao.ExisteCriptomonedaEnBilltera(nombre, idCreador);
        }
        public string ModificarMinadoParaTodos(int nuevominado, string nombrecriptomoneda)
        {
            return billeteravirtualDao.ModificarMinadoParaTodos(nuevominado, nombrecriptomoneda);
        }

    }
}
