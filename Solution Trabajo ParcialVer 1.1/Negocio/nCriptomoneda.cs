using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;


namespace Negocio
{
    public class nCriptomoneda
    {
        dCriptomoneda criptomonedaDao;
        public nCriptomoneda()
        {
            criptomonedaDao = new dCriptomoneda();
        }
        public string Agregar(Criptomoneda criptomoneda)
        {
            return criptomonedaDao.Insertar(criptomoneda);
        }
        public bool ExisteNombreCriptomoneda(String nombrecriptomoneda)
        {
            return criptomonedaDao.ExisteNombreCriptomoneda(nombrecriptomoneda);
        }
        public List<Criptomoneda> ListarCriptomonedaDelCreador(int idcreador)
        {
            return criptomonedaDao.ListarCriptomonedaDelCreador(idcreador);
        }
        public List<Criptomoneda> ListarTodo()
        {
            return criptomonedaDao.ListarTodo();
        }
        public string ModificarInversionPublicidad(Criptomoneda criptomoneda)
        {
            return criptomonedaDao.ModificarInversionPublicidad(criptomoneda);
        }
        public string ModificarInversionSeguridad(Criptomoneda criptomoneda)
        {
            return criptomonedaDao.ModificarInversionSeguridad(criptomoneda);
        }
        public decimal BuscarInversionDeSeguridadConidCriptomoneda(int idCriptomoneda)
        {
            return criptomonedaDao.BuscarInversionSeguridadConidCriptomoneda(idCriptomoneda);
        }
        public decimal BuscarInversionDePublicidadConidCriptomoneda(int idCriptomoneda)
        {
            return criptomonedaDao.BuscarInversionPublicidadConidCriptomoneda(idCriptomoneda);
        }
        public int BuscaridCriptomonedaConNombre(string nombre)
        {
            return criptomonedaDao.BuscaridCriptomonedaConNombre(nombre);
        }
        public decimal BuscarValorCriptomonedaConNombre(string nombrecriptomoneda)
        {
            return criptomonedaDao.BuscarValorConNombreCriptomoneda(nombrecriptomoneda);
        }
        public string ModificarCantidadCriptomoneda(decimal nuevacantidad, string nombrecriptomoneda)
        {
            return criptomonedaDao.ModificarCantidadCriptomoneda(nuevacantidad, nombrecriptomoneda);
        }
        public int BuscarMesConidCriptomoneda(int idCriptomoneda)
        {
            return criptomonedaDao.BuscarMesConidCriptomoneda(idCriptomoneda);
        }
        public int BuscarAñoConidCriptomoneda(int idCriptomoneda)
        {
            return criptomonedaDao.BuscarAñoConidCriptomoneda(idCriptomoneda);
        }
        public string ModificarMesCriptomonedaConidCriptomoneda(int nuevomes, int nuevoaño, int idCriptomoneda)
        {
            return criptomonedaDao.ModificarMesCriptomonedaConidCriptomoneda(nuevomes, nuevoaño, idCriptomoneda);
        }
        public string ModificarValorCriptomonedaConidCriptomoneda(decimal nuevoValor, int idCriptomoneda)
        {
            return criptomonedaDao.ModificarValorCriptomonedaConidCriptomoneda(nuevoValor, idCriptomoneda);
        }


    }
}
