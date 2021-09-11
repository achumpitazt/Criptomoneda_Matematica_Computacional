using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Negocio;
using Entidades;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para WpfNuevaCriptomoneda.xaml
    /// </summary>
    public partial class WpfNuevaCriptomoneda : Window
    {
        nCreador neCreador = new nCreador();
        nCriptomoneda neCriptomoneda = new nCriptomoneda();
        nBilleteraVirtual nebillteraVirtual = new nBilleteraVirtual();
        public WpfNuevaCriptomoneda()
        {
            InitializeComponent();
        }

        private void btn_Atras_Click(object sender, RoutedEventArgs e)
        {
            WpfNuevaCriptomoneda wpfNuevaCriptomoneda = new WpfNuevaCriptomoneda();
            wpfNuevaCriptomoneda.Close();
            InterfazCreador sesionCreador = new InterfazCreador();
            sesionCreador.Show();
            this.Close();
        }

        private void btn_BorrarTodo_Click(object sender, RoutedEventArgs e)
        {
            txb_CodigoEspecial.Clear();
            txb_NombreNuevaCriptomoneda.Clear();
        }

        private void btn_Empezar_Click(object sender, RoutedEventArgs e)
        {
            if (txb_CodigoEspecial.Text != "" && txb_NombreNuevaCriptomoneda.Text != "")
            {
                if (neCreador.YaExisteCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)))
                {
                    if (neCriptomoneda.ExisteNombreCriptomoneda(txb_NombreNuevaCriptomoneda.Text) != true)
                    {
                        Criptomoneda criptomoneda = new Criptomoneda();
                        BilleteraVirtual billeteraVirtual = new BilleteraVirtual();
                        //BilleteraVirtual banco1 = new BilleteraVirtual();
                        //BilleteraVirtual banco2 = new BilleteraVirtual();
                        //BilleteraVirtual banco3 = new BilleteraVirtual();
                        //BilleteraVirtual banco4 = new BilleteraVirtual();
                        criptomoneda.Nombre = txb_NombreNuevaCriptomoneda.Text;
                        criptomoneda.Cantidad = 1;
                        criptomoneda.Valor = Convert.ToDecimal(0.10);
                        criptomoneda.idCreador = neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text));
                        criptomoneda.InversionSeguridad = 0;
                        criptomoneda.InversionPublicidad = 0;
                        criptomoneda.Status = 0;
                        criptomoneda.Mes = 8;
                        criptomoneda.Año = 2009;
                        billeteraVirtual.idCreador = neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text));
                        billeteraVirtual.Nombre = criptomoneda.Nombre;
                        billeteraVirtual.Cantidad = 1;
                        billeteraVirtual.Minado = 0;
                        String respuesta = neCriptomoneda.Agregar(criptomoneda);
                        String respuesta1 = nebillteraVirtual.Agregar(billeteraVirtual);
                        //banco1.idCreador = 1;
                        //banco1.Nombre = criptomoneda.Nombre;
                        //banco1.Cantidad = 0;
                        //banco1.Minado = 0;
                        //banco2.idCreador = 1;
                        //banco2.Nombre = criptomoneda.Nombre;
                        //banco2.Cantidad = 0;
                        //banco2.Minado = 0;
                        //banco3.idCreador = 1;
                        //banco3.Nombre = criptomoneda.Nombre;
                        //banco3.Cantidad = 0;
                        //banco3.Minado = 0;
                        //banco4.idCreador = 1;
                        //banco4.Nombre = criptomoneda.Nombre;
                        //banco4.Cantidad = 0;
                        //banco4.Minado = 0;
                        //string respuesta2 = nebillteraVirtual.Agregar(banco1);
                        //string respuesta3 = nebillteraVirtual.Agregar(banco2);
                        //string respuesta4 = nebillteraVirtual.Agregar(banco3);
                        //string respuesta5 = nebillteraVirtual.Agregar(banco4);


                        MessageBox.Show(respuesta + respuesta1);
                        //MessageBox.Show(respuesta2 + respuesta3 + respuesta4 + respuesta5);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("¡Ya existe una criptomoneda con ese nombre. Ingrese otro nombre.");
                    }

                }
                else
                {
                    MessageBox.Show("El código ingresado no es el correcto. Inténtelo nuevamente.");
                }
            }
            else
            {
                MessageBox.Show("Existe espacios en blanco. ¡Complételos!");
            }
        }
    }
}
