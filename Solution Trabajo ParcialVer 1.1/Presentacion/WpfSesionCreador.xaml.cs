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
    /// Lógica de interacción para SesionCreador.xaml
    /// </summary>
    public partial class SesionCreador : Window
    {
        public SesionCreador()
        {
            InitializeComponent();
        }

        private void btn_NuevoUsuarioCreador_Click(object sender, RoutedEventArgs e)
        {
            WpfNuevoCreador wpfNuevoCreador = new WpfNuevoCreador();
            wpfNuevoCreador.Show();
            this.Close();

        }

        private void btn_IniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            WpfCreador wpfCreador = new WpfCreador();
            wpfCreador.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }
    }
}
