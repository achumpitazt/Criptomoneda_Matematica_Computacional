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
    /// Lógica de interacción para WpfBilleteraCreador.xaml
    /// </summary>
    public partial class WpfBilleteraCreador : Window
    {
        decimal minadofinal;
        nCreador neCreador = new nCreador();
        nCriptomoneda neCriptomoneda = new nCriptomoneda();
        nRecibo neRecibo = new nRecibo();
        nBilleteraVirtual neBilleteraVirtual = new nBilleteraVirtual();
        BilleteraVirtual billeteravirtualSelection = null;
        public WpfBilleteraCreador()
        {
            InitializeComponent();
        }

        private void btn_Mostrar_Click(object sender, RoutedEventArgs e)
        {
            dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
        }

        private void dg_BilleteraVirtual_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            billeteravirtualSelection = (BilleteraVirtual)dg_BilleteraVirtual.SelectedItem;
            if (billeteravirtualSelection != null)
            {
                txb_ValorUnitario.Text = Convert.ToString(neCriptomoneda.BuscarValorCriptomonedaConNombre(billeteravirtualSelection.Nombre));
            }
        }

        private void btn_Minar_Click(object sender, RoutedEventArgs e)
        {
            if (billeteravirtualSelection != null)
            {
                if (billeteravirtualSelection.Minado == 0)
                {
                    if (neCreador.BuscarTipoCpuConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Intel Core i3-2100")
                    {
                        if (neCreador.BuscarTipoRamConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 2)
                        {
                            if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "No tiene")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.002);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, 
                                        billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, 
                                        billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, 
                                        billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada."
                                        +"  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = 
                                        neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32
                                        (txb_CodigoEspecial.Text)));




                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.002);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));

                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.002);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.002);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-750Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.007);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.007);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));

                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.007);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.007);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-1080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.012);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));



                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.012);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));

                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.012);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.012);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia RTX-2080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.017);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));



                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.017);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));

                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.017);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.017);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                        }
                        else if (neCreador.BuscarTipoRamConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 4)
                        {
                            if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "No tiene")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.004);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));



                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.004);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));

                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.004);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                    
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.004);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-750Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.009);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.009);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));

                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.009);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.009);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-1080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.014);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));



                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.014);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));

                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.014);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.014);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia RTX-2080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.019);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));



                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.019);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));

                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.019);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.019);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                        }
                        else if (neCreador.BuscarTipoRamConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 8)
                        {
                            if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "No tiene")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.008);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));



                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.008);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));

                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.008);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.008);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-750Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.013);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));



                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.013);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));

                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.013);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.013);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-1080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.018);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));



                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.018);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));

                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.018);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.018);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia RTX-2080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.023);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));



                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.023);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));

                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.023);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.023);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                        }
                        else if (neCreador.BuscarTipoRamConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 16)
                        {
                            if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "No tiene")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.011);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));



                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.011);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));

                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.011);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.011);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-750Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.016);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));



                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.016);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));

                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.016);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.016);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-1080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.016);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));



                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.012);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));

                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.012);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.012);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia RTX-2080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.017);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));



                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.017);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));

                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.017);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.017);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                        }
                    }
                    else if (neCreador.BuscarTipoCpuConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Intel Core i5-4460")
                    {
                        if (neCreador.BuscarTipoRamConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 2)
                        {
                            if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "No tiene")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.030);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.030);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.030);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.030);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-750Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.040);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.040);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.040);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.040);
                                    decimal tiempo = 14;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-1080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.050);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.050);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.050);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.050);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia RTX-2080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.060);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.060);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.060);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.060);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                        }
                        else if (neCreador.BuscarTipoRamConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 4)
                        {
                            if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "No tiene")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.020);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.020);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.020);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.020);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-750Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.090);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.090);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.090);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.090);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-1080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.10);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.10);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.10);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.020);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia RTX-2080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                        }
                        else if (neCreador.BuscarTipoRamConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 8)
                        {
                            if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "No tiene")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }

                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-750Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.95);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.95);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.95);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.95);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-1080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia RTX-2080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(1.50);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(1.50);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(1.50);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(1.50);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                        }
                        else if (neCreador.BuscarTipoRamConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 16)
                        {
                            if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "No tiene")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }

                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-750Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.95);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.95);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.95);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.95);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-1080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia RTX-2080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(1.50);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(1.50);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(1.50);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(1.50);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                        }
                    }
                    else if (neCreador.BuscarTipoCpuConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Intel Core i7-3960X")
                    {
                        if (neCreador.BuscarTipoRamConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 2)
                        {
                            if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "No tiene")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }

                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-750Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.95);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.95);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.95);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.95);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-1080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia RTX-2080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(1.50);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(1.50);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(1.50);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(1.50);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                        }
                        else if (neCreador.BuscarTipoRamConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 4)
                        {
                            if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "No tiene")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }

                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-750Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.95);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.95);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.95);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.95);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-1080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia RTX-2080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(1.50);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(1.50);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(1.50);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(1.50);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                        }
                        else if (neCreador.BuscarTipoRamConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 8)
                        {
                            if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "No tiene")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }

                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-750Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.95);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.95);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.95);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.95);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-1080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia RTX-2080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(1.50);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(1.50);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(1.50);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(1.50);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                        }
                        else if (neCreador.BuscarTipoRamConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 16)
                        {
                            if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "No tiene")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.25);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.25);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.25);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.25);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }

                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-750Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-1080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.75);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.75);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.75);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.75);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia RTX-2080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.75);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.75);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.75);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.75);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                        }
                    }
                    else if (neCreador.BuscarTipoCpuConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Intel Core i9-9900K")
                    {
                        if (neCreador.BuscarTipoRamConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 2)
                        {
                            if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "No tiene")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.30);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.30);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.30);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.30);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }

                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-750Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.65);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.65);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.65);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.65);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-1080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.70);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.70);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.70);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.70);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia RTX-2080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.85);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.85);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.85);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.85);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                        }
                        else if (neCreador.BuscarTipoRamConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 4)
                        {
                            if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "No tiene")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.50);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.50);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.50);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.50);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }

                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-750Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.85);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.85);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.85);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.85);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-1080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.9);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.9);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.9);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.9);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia RTX-2080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(1.05);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(1.05);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(1.05);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(1.05);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                        }
                        else if (neCreador.BuscarTipoRamConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 8)
                        {
                            if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "No tiene")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.50);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.50);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.50);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.50);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }

                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-750Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.90);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.90);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.90);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.90);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-1080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia RTX-2080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(1.25);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(1.25);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(1.25);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(1.25);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                        }
                        else if (neCreador.BuscarTipoRamConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 16)
                        {
                            if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "No tiene")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.55);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-750Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(0.95);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(0.95);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(0.95);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(0.95);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia GTX-1080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(1.0);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            else if (neCreador.BuscarTipoTarjetaGrafica(Convert.ToInt32(txb_CodigoEspecial.Text)) == "Nvidia RTX-2080Ti")
                            {
                                if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 3)
                                {
                                    decimal minado = Convert.ToDecimal(1.50);
                                    decimal tiempo = 3;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera
                                        (billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, 
                                        billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, 
                                        billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." 
                                        + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador
                                        (neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 6)
                                {
                                    decimal minado = Convert.ToDecimal(1.50);
                                    decimal tiempo = 6;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 12)
                                {
                                    decimal minado = Convert.ToDecimal(1.50);
                                    decimal tiempo = 12;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                                else if (neCreador.BuscarTiempoConexionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)) == 24)
                                {
                                    decimal minado = Convert.ToDecimal(1.50);
                                    decimal tiempo = 24;
                                    decimal dias = 30;
                                    decimal aux = (1 * minado * tiempo * dias);
                                    minadofinal = (neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador) + aux);
                                    string respuesta = neBilleteraVirtual.ModificarCantidadBillteraVirtual(minadofinal, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    string respuesta2 = neBilleteraVirtual.ModificarMinadoConNombreCriptomoneda(1, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                    MessageBox.Show(respuesta + Convert.ToString(aux) + " de su criptomoneda seleccionada." + "  " + respuesta2);
                                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                }
                            }
                            

                            
                        }
                    }
                }
                else
                {
                    MessageBox.Show(" Ya minó la criptomoneda en este mes, seleccione otra.");
                }



            }
            else
            {
                MessageBox.Show("Seleccione la criptomoneda que desea minar. Error en el proceso.");
            }
        }

        private void btn_Enviar_Click(object sender, RoutedEventArgs e)
        {
            if (billeteravirtualSelection != null)
            {

                if (neCreador.ExisteidCreadir(Convert.ToInt32(txb_idDestinatario.Text))== true)
                {
                    if (Convert.ToDecimal(txb_Monto.Text) > 0)
                    {
                        if (Convert.ToDecimal(txb_Monto.Text) < neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador))
                        {
                            if (neBilleteraVirtual.ExisteCriptomonedaEnBilletera(billeteravirtualSelection.Nombre,Convert.ToInt32(txb_idDestinatario.Text)) == true)
                            {
                                decimal aux = neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador);
                                decimal aux2 = neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, Convert.ToInt32(txb_idDestinatario.Text));
                                decimal finalaux = aux - Convert.ToDecimal(txb_Monto.Text);
                                decimal finalaux2 = aux2 + Convert.ToDecimal(txb_Monto.Text);
                                string respuesta1 = neBilleteraVirtual.ModificarCantidadBillteraVirtual(finalaux, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                string respuesta2 = neBilleteraVirtual.ModificarCantidadBillteraVirtual(finalaux2, Convert.ToInt32(txb_idDestinatario.Text), billeteravirtualSelection.Nombre);
                                MessageBox.Show(respuesta1 + respuesta2);
                                
                                Recibo recibo = new Recibo();
                                recibo.idEmisor = neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text));
                                recibo.NombreEmisor = neCreador.BuscarNombre(Convert.ToInt32(txb_CodigoEspecial.Text));
                                recibo.idDestinatario = Convert.ToInt32(txb_idDestinatario.Text);
                                recibo.NombreDestinantario = neCreador.BuscarNombreConIdCreador(Convert.ToInt32(txb_idDestinatario.Text));
                                recibo.Motivo = " Depósito ";
                                recibo.Cantidad = Convert.ToDecimal(txb_Monto.Text);
                                recibo.NombreCriptomoneda = billeteravirtualSelection.Nombre;
                                string respuesta3 = neRecibo.InsertarRecibo(recibo);
                                dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                MessageBox.Show(respuesta3);
                            }
                            else
                            {
                                decimal aux = neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador);
                                decimal finalaux = aux - Convert.ToDecimal(txb_Monto.Text);

                                string respuesta = neBilleteraVirtual.Agregar2(Convert.ToInt32(txb_idDestinatario.Text), billeteravirtualSelection.Nombre,Convert.ToDecimal(txb_Monto.Text) , 0);
                                string respuesta1 = neBilleteraVirtual.ModificarCantidadBillteraVirtual(finalaux, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                                MessageBox.Show(respuesta + respuesta1);
                                
                                Recibo recibo = new Recibo();
                                recibo.idEmisor = neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text));
                                recibo.NombreEmisor = neCreador.BuscarNombre(Convert.ToInt32(txb_CodigoEspecial.Text));
                                recibo.idDestinatario = Convert.ToInt32(txb_idDestinatario.Text);
                                recibo.NombreDestinantario = neCreador.BuscarNombreConIdCreador(Convert.ToInt32(txb_idDestinatario.Text));
                                recibo.Motivo = "Depósito";
                                recibo.Cantidad = Convert.ToDecimal(txb_Monto.Text);
                                recibo.NombreCriptomoneda = billeteravirtualSelection.Nombre;
                                string respuesta3 = neRecibo.InsertarRecibo(recibo);
                                dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                                MessageBox.Show(respuesta3);

                            }
                           
                            
                        }
                        else
                        {
                            MessageBox.Show(" El monto digitado es mayor a lo que posees en tu billetera. Inserte una nueva cantidad.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No puede ingresa números negativos ni ceros. Digite una cantidad adecuada.");
                    }
                }
                else
                {
                    MessageBox.Show(" Inserte un código idCorrecto. Error en el proceso. ");
                }
            }
            else
            {
                MessageBox.Show(" Primero seleccione una criptomoneda que desee enviar. ");
            }
        }

        private void btn_Vender_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDecimal(txb_Venta.Text) > 0)
            {
                if (Convert.ToDecimal(txb_Venta.Text) < neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador))
                {
                    decimal aux = neBilleteraVirtual.BuscarCantidadConidCreadorBilltera(billeteravirtualSelection.Nombre, billeteravirtualSelection.idCreador);
                    decimal finalaux = aux - Convert.ToDecimal(txb_Venta.Text);
                    string respuesta1 = neBilleteraVirtual.ModificarCantidadBillteraVirtual(finalaux, billeteravirtualSelection.idCreador, billeteravirtualSelection.Nombre);
                    decimal aux2 = neCreador.BuscarRetiroConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text));
                    decimal aux3 = neCriptomoneda.BuscarValorCriptomonedaConNombre(billeteravirtualSelection.Nombre) * Convert.ToDecimal(txb_Venta.Text) ;
                    decimal finalaux2 = aux2 + aux3;
                    string respuesta2 = neCreador.ModificarRetiroConCodigoEspecial(finalaux2, Convert.ToInt32(txb_CodigoEspecial.Text));
                    Recibo recibo = new Recibo();
                    recibo.idEmisor = neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text));
                    recibo.NombreEmisor = neCreador.BuscarNombre(Convert.ToInt32(txb_CodigoEspecial.Text));
                    recibo.idDestinatario = 0;
                    recibo.NombreDestinantario = "Banco";
                    recibo.Motivo = "Venta";
                    recibo.Cantidad = Convert.ToDecimal(txb_Venta.Text);
                    recibo.NombreCriptomoneda = billeteravirtualSelection.Nombre;
                    string respuesta3 = neRecibo.InsertarRecibo(recibo);
                    MessageBox.Show(respuesta1);
                    MessageBox.Show(respuesta2);
                    MessageBox.Show(respuesta3);
                    dg_BilleteraVirtual.ItemsSource = neBilleteraVirtual.ListarBilleteraConidCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                }
                else
                {
                    MessageBox.Show(" El monto digitado es mayor a lo que posees en tu billetera. Inserte una nueva cantidad.");
                }
            }
            else
            {
                MessageBox.Show("No puede ingresa números negativos ni ceros. Digite una cantidad adecuada.");
            }
        }

        private void btn_Recibo_Click(object sender, RoutedEventArgs e)
        {
            WpfRecibo wpfRecibo = new WpfRecibo();
            wpfRecibo.Show();
            Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            InterfazCreador i = new InterfazCreador();
            i.Show();
            this.Close();
        }
    }
}


