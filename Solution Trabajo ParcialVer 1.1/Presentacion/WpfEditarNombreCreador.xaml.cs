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
using Entidades;
using Negocio;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para WpfEditarNombreCreador.xaml
    /// </summary>
    public partial class WpfEditarNombreCreador : Window
    {
        public WpfEditarNombreCreador()
        {
            InitializeComponent();
            
        }
        nCreador neCreador = new nCreador();
        Creador creadorSelection = new Creador();
        private void btn_Borrar_Click(object sender, RoutedEventArgs e)
        {
            txb_CodigoEspecial.Clear();
            txb_Contraseña.Clear();
            txb_NuevoNombre.Clear();
        }

        private void btn_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            WpfEditarDatosCreador interfazCreador = new WpfEditarDatosCreador();
            interfazCreador.Show();
            this.Close();
        }

        private void btn_Continuar_Click(object sender, RoutedEventArgs e)
        {
            if (neCreador.YaExisteCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)))
            {
                if (neCreador.BuscarContraseñaConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == txb_Contraseña.Text)
                {
                                      
                    creadorSelection.idCreador = neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text));
                    creadorSelection.Nombre = txb_NuevoNombre.Text;
                    creadorSelection.Apellido = txb_Apellido.Text;
                    String respuesta = neCreador.ModificarNombres(creadorSelection);
                    MessageBox.Show(respuesta);
                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta.");
                }
                

            }
            else
            {
                MessageBox.Show("Completa el especio en blanco.");
            }
        }
    }
}
