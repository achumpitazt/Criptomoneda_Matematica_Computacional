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
    /// Lógica de interacción para WpfNuevoCreador.xaml
    /// </summary>
    public partial class WpfNuevoCreador : Window
    {
        nCreador neCreador = new nCreador();
        
        public WpfNuevoCreador()
        {
            InitializeComponent();
        }

        private void btn_Borrar_Click(object sender, RoutedEventArgs e)
        {
            txb_Nombre.Clear();
            txb_Apellido.Clear();
            txb_Email.Clear();
            txb_Contraseña.Clear();
            txb_ConfirmarContraseña.Clear();
        }

        private void btn_PaginaAnterior_Click(object sender, RoutedEventArgs e)
        {
            WpfNuevoCreador wpfNuevoCreador = new WpfNuevoCreador();
            SesionCreador sesionCreador = new SesionCreador();
            sesionCreador.Show();
            wpfNuevoCreador.Close();
            this.Close();
            
        }

        private void btn_CrearCreador_Click(object sender, RoutedEventArgs e)
        {
            if (txb_Nombre.Text != "" && txb_Apellido.Text != "" && txb_Email.Text != "" && txb_Contraseña.Text != "")
            {
                if (txb_Contraseña.Text == txb_ConfirmarContraseña.Text)
                {
                    var random = new Random();
                    var valoraelatorio = random.Next(0, 9999);
                    Creador creador = new Creador();
                    creador.Nombre = txb_Nombre.Text;
                    creador.Apellido = txb_Apellido.Text;
                    creador.Email = txb_Email.Text;
                    creador.Contraseña = txb_Contraseña.Text;
                    creador.CodigoEspecial = valoraelatorio;
                    creador.Inversion = 0;
                    creador.Retiro = 0;
                    creador.TipoCpu = "Intel Core i3-2100";
                    creador.TipoRam = 2;
                    creador.TipoTarjetaGrafica = "No tiene";
                    creador.TiempoConexion = 3;
                    creador.NumeroTransacciones = 0;
                    String respuesta = neCreador.Agregar(creador);
                    txb_Nombre.Clear();
                    txb_Apellido.Clear();
                    txb_Email.Clear();
                    txb_Contraseña.Clear();
                    txb_ConfirmarContraseña.Clear();
                    MessageBox.Show("Felicidades " + txb_Nombre.Text + " " + txb_Apellido.Text + ". " +
                        "Ya se encuentra registrado. " + respuesta);
                 
                }
                else
                {
                    MessageBox.Show(" Confirme de nuevo su contraseña. Error en el proceso.");
                }
            }
            else
            {
                MessageBox.Show("Error en el proceso. Complete los espacios en blanco.");
            }
        }
    }
}
