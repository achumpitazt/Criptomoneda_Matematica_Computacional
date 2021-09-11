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
    /// Lógica de interacción para WpfRedesSociales.xaml
    /// </summary>
    public partial class WpfRedesSociales : Window
    {
        public WpfRedesSociales()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" No hay nada interesante para ver hoy. ");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Nuevamente las mismas fotos. Nada interesante. ");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Los mismos post de siempre. No hay nada nuevo que ver. ");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Aún esa person especial no te responde. Quizás puedas hacer tiempo en otras aplicaciones. ");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            SesionCreador sesionCreador = new SesionCreador();
            sesionCreador.Show();
            Close();

        }
    }
}
