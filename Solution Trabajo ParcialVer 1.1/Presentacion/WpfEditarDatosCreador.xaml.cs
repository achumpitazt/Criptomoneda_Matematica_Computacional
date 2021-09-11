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

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para WpfEditarDatosCreador.xaml
    /// </summary>
    public partial class WpfEditarDatosCreador : Window
    {
        public WpfEditarDatosCreador()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WpfEditarEmailCreador wpfEditarEmailCreador = new WpfEditarEmailCreador();
            wpfEditarEmailCreador.Show();
            Close();
        }

        private void btn_CambiarNombre_Click(object sender, RoutedEventArgs e)
        {
            WpfEditarNombreCreador wpfEditarNombreCreador = new WpfEditarNombreCreador();
            wpfEditarNombreCreador.Show();
            Close();
        }

        private void btn_EditarComponentes_Click(object sender, RoutedEventArgs e)
        {
            WpfEditarComponentesCreador wpfEditarComponentesCreador = new WpfEditarComponentesCreador();
            wpfEditarComponentesCreador.Show();
            Close();
        }

        private void btn_Cerrar_Click(object sender, RoutedEventArgs e)
        {
            InterfazCreador i = new InterfazCreador();
            i.Show();
            this.Close();
        }
    }
}
