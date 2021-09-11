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
    /// Lógica de interacción para WpfCreador.xaml
    /// </summary>
    public partial class WpfCreador : Window
    {
        nCreador neCreador = new nCreador();
        public WpfCreador()
        {
            InitializeComponent();
        }

        private void btn_Continuar_Click(object sender, RoutedEventArgs e)
        {
            if (txb_Email.Text != "" && txb_Contraseña.Text != "")
            {
                if (neCreador.YaExisteEmail(txb_Email.Text))
                {
                    if (txb_Contraseña.Text == neCreador.BuscarporEmail(txb_Email.Text))
                    {
                        bool aux = false;
                        var random = new Random();
                        var valoraelatorio = random.Next(0, 9999);
                        while (aux == true)
                        {
                            aux = neCreador.YaExisteCodigoEspecial(valoraelatorio);
                        }
                        neCreador.ModificarCodigoConEmail(valoraelatorio, txb_Email.Text);
                        MessageBox.Show("Su código de encriptación temporal es: "+valoraelatorio.ToString());
                        WpfCreador wpfCreador = new WpfCreador();
                        InterfazCreador interfazCreador = new InterfazCreador();

                        interfazCreador.Show();
                        wpfCreador.Close();
                        this.Close();


                    }
                    else
                    {
                        MessageBox.Show("Ingrese bien su contraseña.");
                    }
                }
                else
                {
                    MessageBox.Show("Su Email no está registrado en la base de datos.");
                }
            }
            else
            {
                MessageBox.Show("Existen campos vacíos. Complételos");
            }
        }

        private void btn_PaginaAnterior_Click(object sender, RoutedEventArgs e)
        {
            SesionCreador sesionCreador = new SesionCreador();
            sesionCreador.Show();
            this.Close();
        }
    }
}
