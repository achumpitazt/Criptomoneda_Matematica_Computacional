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
    /// Lógica de interacción para WpfEditarEmailCreador.xaml
    /// </summary>
    public partial class WpfEditarEmailCreador : Window
    {
        public WpfEditarEmailCreador()
        {
            InitializeComponent();
        }
        nCreador neCreador = new nCreador();

        private void btnRegresar_Click(object sender, RoutedEventArgs e)
        {
            WpfEditarDatosCreador wpfCreador = new WpfEditarDatosCreador();
            wpfCreador.Show();
            this.Close();
        }

        private void btn_Cambiar_Click(object sender, RoutedEventArgs e)
        {
            if (neCreador.YaExisteCodigoEspecial(Convert.ToInt32(txbCodigoEspecial.Text)))
            {
                if (neCreador.YaExisteEmail(txbEmailActual.Text))
                {
                    if (neCreador.BuscarCodigoEspecialConEmail(txbEmailActual.Text)==Convert.ToInt32(txbCodigoEspecial.Text))
                    {
                        string respuesta = neCreador.ModificarEmailConCodigoEspecial(txbNuevoEmail.Text, Convert.ToInt32(txbCodigoEspecial.Text));
                        MessageBox.Show(respuesta);
                    }
                    else
                    {
                        MessageBox.Show("Los datos ingresados no son correctos. Inténtelo nuevamente.");
                    }
                }
                else
                {
                    MessageBox.Show("No existe dicho email en la base de datos.");
                }
            }
            else
            {
                MessageBox.Show("No existe el código proporcionado, ingréselo nuevamente.");
            }
        }
    }
}
