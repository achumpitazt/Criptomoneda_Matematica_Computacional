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
    /// Lógica de interacción para WpfEditarComponentesCreador.xaml
    /// </summary>
    public partial class WpfEditarComponentesCreador : Window
    {
        public WpfEditarComponentesCreador()
        {
            InitializeComponent();
        }
        nCreador neCreador = new nCreador();

        private void btn_Volver_Click(object sender, RoutedEventArgs e)
        {
            WpfEditarDatosCreador wpfCreador = new WpfEditarDatosCreador();
            wpfCreador.Show();
            this.Close();
        }

        private void btn_Modificar_Click(object sender, RoutedEventArgs e)
        {
            if (neCreador.YaExisteCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)))
            {
                if (txb_CodigoHardware.Text == "0734597AF322H")
                {
                    string respuesta = neCreador.ModificarCpuConCodigoEspecial("Intel Core i5-4460", Convert.ToInt32(txb_CodigoEspecial.Text));
                    MessageBox.Show(respuesta);
                    MessageBox.Show("Actualizó su microprocesador a una Intel Core i5-4460");
                    if (rdb_3horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(3, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show( "Su tiempo ahora es de 3 horas.");
                    }
                    else if (rdb_6horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(6, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 6 horas.");
                    }
                    else if (rdb_12horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(12, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 12 horas.");
                    }
                    else if (rdb_24horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(24, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 24 horas.");
                    }
                }
                else if (txb_CodigoHardware.Text == "794ZA1B569Z0C")
                {
                    string respuesta = neCreador.ModificarCpuConCodigoEspecial("Intel Core i7-3960X", Convert.ToInt32(txb_CodigoEspecial.Text));
                    MessageBox.Show(respuesta);
                    MessageBox.Show("Actualizó su microprocesador a una Intel Core i7-3960X");
                    if (rdb_3horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(3, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 3 horas.");
                    }
                    else if (rdb_6horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(6, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 6 horas.");
                    }
                    else if (rdb_12horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(12, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 12 horas.");
                    }
                    else if (rdb_24horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(24, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 24 horas.");
                    }
                }
                else if (txb_CodigoHardware.Text == "#*@199948HIJ7")
                {
                    string respuesta = neCreador.ModificarCpuConCodigoEspecial("Intel Core i9-9900k", Convert.ToInt32(txb_CodigoEspecial.Text));
                    MessageBox.Show(respuesta);
                    MessageBox.Show("Actualizó su microprocesador a una Intel Core i9-9900k");
                    if (rdb_3horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(3, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 3 horas.");
                    }
                    else if (rdb_6horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(6, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 6 horas.");
                    }
                    else if (rdb_12horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(12, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 12 horas.");
                    }
                    else if (rdb_24horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(24, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 24 horas.");
                    }
                }
                else if (txb_CodigoHardware.Text == "T0081UR97T1LE")
                {
                    string respuesta = neCreador.ModificarRamConCodigoEspecial(4, Convert.ToInt32(txb_CodigoEspecial));
                    
                    MessageBox.Show(respuesta);
                    MessageBox.Show("Actualizó su Ram a una de capacidad de 4 GB");
                    if (rdb_3horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(3, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 3 horas.");
                    }
                    else if (rdb_6horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(6, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 6 horas.");
                    }
                    else if (rdb_12horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(12, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 12 horas.");
                    }
                    else if (rdb_24horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(24, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 24 horas.");
                    }
                }
                else if (txb_CodigoHardware.Text == "R55ABB18I000T")
                {
                    string respuesta = neCreador.ModificarRamConCodigoEspecial(8, Convert.ToInt32(txb_CodigoEspecial));
                    
                    MessageBox.Show(respuesta);
                    MessageBox.Show("Actualizó su Ram a una de capacidad de 8 GB");
                    if (rdb_3horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(3, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 3 horas.");
                    }
                    else if (rdb_6horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(6, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 6 horas.");
                    }
                    else if (rdb_12horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(12, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 12 horas.");
                    }
                    else if (rdb_24horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(24, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 24 horas.");
                    }
                }
                else if (txb_CodigoHardware.Text == "F497A34453TER")
                {
                    string respuesta = neCreador.ModificarRamConCodigoEspecial(16, Convert.ToInt32(txb_CodigoEspecial));

                    MessageBox.Show(respuesta);
                    MessageBox.Show("Actualizó su Ram a una de capacidad de 16 GB");
                    if (rdb_3horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(3, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 3 horas.");
                    }
                    else if (rdb_6horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(6, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 6 horas.");
                    }
                    else if (rdb_12horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(12, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 12 horas.");
                    }
                    else if (rdb_24horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(24, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 24 horas.");
                    }
                }
                else if (txb_CodigoHardware.Text == "M49AIN5STREAM")
                {
                    string respuesta = neCreador.ModificarTarjetaGraficaConCodigoEspecial("Nvidia GTX-750Ti", Convert.ToInt32(txb_CodigoEspecial));
                    MessageBox.Show(respuesta);
                    MessageBox.Show("Su tarjeta gráfica ahora es una Nvidia GTX-750Ti");
                    if (rdb_3horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(3, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 3 horas.");
                    }
                    else if (rdb_6horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(6, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 6 horas.");
                    }
                    else if (rdb_12horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(12, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 12 horas.");
                    }
                    else if (rdb_24horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(24, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 24 horas.");
                    }
                }
                else if (txb_CodigoHardware.Text == "H47A18R9D54ER")
                {
                    string respuesta = neCreador.ModificarTarjetaGraficaConCodigoEspecial("Nvidia GTX-1080Ti", Convert.ToInt32(txb_CodigoEspecial));
                    MessageBox.Show(respuesta);
                    MessageBox.Show("Su tarjeta gráfica ahora es una Nvidia GTX-10800Ti");
                    if (rdb_3horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(3, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 3 horas.");
                    }
                    else if (rdb_6horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(6, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 6 horas.");
                    }
                    else if (rdb_12horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(12, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 12 horas.");
                    }
                    else if (rdb_24horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(24, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 24 horas.");
                    }
                }
                else if (txb_CodigoHardware.Text == "P77114R947052")
                {
                    string respuesta = neCreador.ModificarTarjetaGraficaConCodigoEspecial("Nvidia RTX-2080Ti", Convert.ToInt32(txb_CodigoEspecial.Text));
                    MessageBox.Show(respuesta);
                    MessageBox.Show("Su tarjeta gráfica ahora es una Nvidia RTX-2080Ti");
                    if (rdb_3horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(3, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 3 horas.");
                    }
                    else if (rdb_6horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(6, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 6 horas.");
                    }
                    else if (rdb_12horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(12, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 12 horas.");
                    }
                    else if (rdb_24horas.IsChecked == true)
                    {
                        string respuesta2 = neCreador.ModificarTiempoConexionConCodigoEspecial(24, Convert.ToInt32(txb_CodigoEspecial.Text));
                        MessageBox.Show(respuesta2);
                        MessageBox.Show("Su tiempo ahora es de 24 horas.");
                    }
                }
                else
                {
                    MessageBox.Show("El código ingresado no es el correcto, inténtelo nuevamente. Error en el proceso.");
                }
                
            }
            else
            {
                MessageBox.Show("Su código especial no existe en la base de datos.");
            }
        }
    }
}
