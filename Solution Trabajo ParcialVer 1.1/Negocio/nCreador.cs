using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class nCreador
    {
        dCreador creadorDao;
        public nCreador()
        {
            creadorDao = new dCreador();
        }
        public string Agregar(Creador creador)
        {
            return creadorDao.Insertar(creador);
        }
        public bool YaExisteEmail(String email)
        {
            return creadorDao.Existe_email_creador(email);
        }
        public bool YaExisteCodigoEspecial(int codigoespecial)
        {
            return creadorDao.Existe_Codigo_creador(codigoespecial);
        }
        public String BuscarporEmail(String email)
        {
            return creadorDao.BuscarPorEmailCreador(email);
        }
        public int BuscarCodigoEspecialConEmail(string email)
        {
            return creadorDao.BuscarCodigoEspecialConEmail(email);
        }
        public String BuscarNombre(int codigoespecial)
        {
            return creadorDao.BuscarNombre(codigoespecial);
        }
        public String BuscarApellido(int codigoespecial)
        {
            return creadorDao.BuscarApellido(codigoespecial);
        }
        public string ModificarCodigoConEmail(int a, String Email)
        {
            return creadorDao.ModificarPinConEmail(a, Email);
        }
        public string ModificarCodigoEspecialConCodigoEspecial(int nuevo, int antiguo)
        {
            return creadorDao.ModificarCodigoEspecialConCodigoEspecial(nuevo, antiguo);
        }
        public int BuscarIdCreadorConCodigoEspecial(int codigoesoecial)
        {
            return creadorDao.BuscarIdCreadorConCodigoEspecial(codigoesoecial);
        }
        public string ModificarNombres(Creador creador)
        {
            return creadorDao.ModificarNombre(creador);
        }
        public string BuscarContraseñaConCodigoEspecial(int codigoespecial)
        {
            return creadorDao.BuscarContraseñaConCodigoEspecial(codigoespecial);
        }
        public string BuscarTipoCpuConCodigoEspecial(int codigoespecial)
        {
            return creadorDao.BuscarTipoCpuConCodigoEspecial(codigoespecial);
        }
        public int BuscarTipoRamConCodigoEspecial(int codigoespecial)
        {
            return creadorDao.BuscarTipoRamConCodigoEspecial(codigoespecial);
        }
        public string BuscarTipoTarjetaGrafica(int codigoespecial)
        {
            return creadorDao.BuscarTipoTarjetaGraficaConCodigoEspecial(codigoespecial);
        }
        public int BuscarTiempoConexionConCodigoEspecial(int codigoespecial)
        {
            return creadorDao.BuscarTiempoConexion(codigoespecial);
        }
        public string ModificarCpuConCodigoEspecial(string nuevacpu, int codigoespecial)
        {
            return creadorDao.ModificarTipoCpuConCodigoEspecial(nuevacpu, codigoespecial);
        }
        public string ModificarRamConCodigoEspecial(int nuevaram, int codigoespecial)
        {
            return creadorDao.ModificarTipoRamConCodigoEspecial(nuevaram, codigoespecial);
        }
        public string ModificarTarjetaGraficaConCodigoEspecial(string nuevatarjetagrafica, int codigoespecial)
        {
            return creadorDao.ModificarTipoTarjetaGraficaConCodigoEspecial(nuevatarjetagrafica, codigoespecial);
        }
        public string ModificarEmailConCodigoEspecial(string email, int codigoespecial)
        {
            return creadorDao.ModificarEmailConCodigoEspecial(email, codigoespecial);
        }
        public bool ExisteidCreadir(int idCreador)
        {
            return creadorDao.ExisteidCreador(idCreador);
        }
        public string ModificarTiempoConexionConCodigoEspecial(int nuevotiempoconexion, int codigoespecial)
        {
            return creadorDao.ModificarTiempoConexionConCodigoEspecial(nuevotiempoconexion, codigoespecial);
        }
        public decimal BuscarInversionConCodigoEspecial(int codigoespecial)
        {
            return creadorDao.BuscarInversionConCodigoEspecial(codigoespecial);
        }
        public string ModificarInversionConCodigoEspecial(decimal nuevainversion, int codigoespecial)
        {
            return creadorDao.ModificarInversionConCodigoEspecial(nuevainversion, codigoespecial);
        }
        public decimal BuscarRetiroConCodigoEspecial(int codigoespecial)
        {
            return creadorDao.BuscarRetiroConCodigoEspecial(codigoespecial);
        }
        public string ModificarRetiroConCodigoEspecial(decimal nuevainversion, int codigoespecial)
        {
            return creadorDao.ModificarRetiroConCodigoEspecial(nuevainversion, codigoespecial);
        }
        public string BuscarNombreConIdCreador(int idCreador)
        {
            return creadorDao.BuscarNombreConidCreador(idCreador);
        }
        

    }
}
