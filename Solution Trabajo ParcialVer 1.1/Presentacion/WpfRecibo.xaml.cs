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
    /// Lógica de interacción para WpfRecibo.xaml
    /// </summary>
    public partial class WpfRecibo : Window
    {
        nRecibo neRecibo = new nRecibo();
        nCreador neCreador = new nCreador();
        public WpfRecibo()
        {
            InitializeComponent();
        }

        private void btn_Validar_Click(object sender, RoutedEventArgs e)
        {
            dg_Recibo.ItemsSource = neRecibo.ListarRecibosCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txbCodigoEspecial.Text)));
            dg_MeEnviaron.ItemsSource = neRecibo.ListarDestinatarioDelCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txbCodigoEspecial.Text)));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            WpfBilleteraCreador w = new WpfBilleteraCreador();
            w.Show();
            this.Close();
        }
    }
}
