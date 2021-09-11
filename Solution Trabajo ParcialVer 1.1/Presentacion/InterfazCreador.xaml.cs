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
    /// Lógica de interacción para InterfazCreador.xaml
    /// </summary>
    public partial class InterfazCreador : Window
    {
        public InterfazCreador()
        {
            InitializeComponent();
            
        }
        nCreador neCreador = new nCreador();
        nCriptomoneda neCriptomoneda = new nCriptomoneda();
        nBilleteraVirtual neBilleteraVirtual = new nBilleteraVirtual();
        Criptomoneda criptomonedaSelection = null;
        int idCriptomoneda;
        decimal PublicidadAuxiliar;
        decimal SeguridadAuxiliar;
        decimal SeguridadFinal;
        decimal PublicidadFinal;
        
        
       

        private void btn_Insertar_Click(object sender, RoutedEventArgs e)
        {
            if (txb_CodigoEspecial.Text != "")
            {
                if (neCreador.YaExisteCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)))
                {
                    txb_Nombre.Text = neCreador.BuscarNombre(Convert.ToInt32(txb_CodigoEspecial.Text));
                    txb_Apellido.Text = neCreador.BuscarApellido(Convert.ToInt32(txb_CodigoEspecial.Text));
                    txb_Inversion.Text = Convert.ToString(neCreador.BuscarInversionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                    txb_Retiro.Text = Convert.ToString(neCreador.BuscarRetiroConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                    dgEmpleos.ItemsSource = neCriptomoneda.ListarCriptomonedaDelCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                      
                }
                else
                {
                    MessageBox.Show(" Su código especial no existe en nuestra base de datos. Error en el proceso.");
                }
                  
            }
            else
            {
                MessageBox.Show("Completa el especio en blanco.");
            }
        }

        private void btn_CrearCriptomoneda_Click(object sender, RoutedEventArgs e)
        {
            WpfNuevaCriptomoneda wpfNuevaCriptomoneda = new WpfNuevaCriptomoneda();
            wpfNuevaCriptomoneda.Show();
            Close();
            
        }

       

        private void btn_Invertir_Click(object sender, RoutedEventArgs e)
        {
            if (rdb_InvercionSeguridad.IsChecked == true)
            {
                if (txb_Seguridad.Text != "")
                {
                    if (criptomonedaSelection != null)
                    {
                        if (Convert.ToDecimal(txb_Seguridad.Text) > 0)
                        {
                            decimal InversionAuxiliar = neCreador.BuscarInversionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text));
                            decimal InversionFinal = Convert.ToDecimal(txb_Seguridad.Text) + InversionAuxiliar;
                            SeguridadAuxiliar = criptomonedaSelection.InversionSeguridad;
                            SeguridadFinal = SeguridadAuxiliar + Convert.ToDecimal(txb_Seguridad.Text);
                            criptomonedaSelection.InversionSeguridad = SeguridadFinal;
                            
                            String respuesta = neCriptomoneda.ModificarInversionSeguridad(criptomonedaSelection);
                            string respuesta1 = neCreador.ModificarInversionConCodigoEspecial(InversionFinal, Convert.ToInt32(txb_CodigoEspecial.Text));
                            txb_Inversion.Text = Convert.ToString(neCreador.BuscarInversionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                            dgEmpleos.ItemsSource = neCriptomoneda.ListarCriptomonedaDelCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                            MessageBox.Show(respuesta);
                            MessageBox.Show(respuesta1);
                        }
                        else
                        {
                            MessageBox.Show("Ingrese una cantidad válida para poder continuar.");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Seleccione la criptomoneda en el que desea invertir Seguridad. Error en el proceso.");
                    }
                }
                else
                {
                    MessageBox.Show("No puede dejar espacios en blanco. ¡Complételo!");
                }
            }
            else if (rdb_InversionPublicidad.IsChecked == true)
            {
                if (txb_Publicidad.Text != "")
                {
                    if (criptomonedaSelection != null)
                    {
                        if (Convert.ToDecimal(txb_Publicidad.Text) > 0)
                        {
                            decimal InversionAuxiliar = neCreador.BuscarInversionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text));
                            decimal InversionFinal = Convert.ToDecimal(txb_Publicidad.Text) + InversionAuxiliar;
                            PublicidadAuxiliar = criptomonedaSelection.InversionPublicidad;
                            PublicidadFinal = PublicidadAuxiliar + Convert.ToDecimal(txb_Publicidad.Text);
                            criptomonedaSelection.InversionPublicidad = PublicidadFinal;
                            String respuesta = neCriptomoneda.ModificarInversionPublicidad(criptomonedaSelection);
                            string respuesta1 = neCreador.ModificarInversionConCodigoEspecial(InversionFinal, Convert.ToInt32(txb_CodigoEspecial.Text));
                            txb_Inversion.Text = Convert.ToString(neCreador.BuscarInversionConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                            dgEmpleos.ItemsSource = neCriptomoneda.ListarCriptomonedaDelCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
                            MessageBox.Show(respuesta);
                            MessageBox.Show(respuesta1);
                        }
                        else
                        {
                            MessageBox.Show("Ingrese una cantidad válida para poder continuar.");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Seleccione la criptomoneda en el que desea invertir publicidad. Error en el proceso.");
                    }
                    
                }
                else
                {
                    MessageBox.Show("No puede dejar espacios en blanco. ¡Complételo!");
                }
            }
        }

        private void dgEmpleos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            criptomonedaSelection = (Criptomoneda)dgEmpleos.SelectedItem;
            if (criptomonedaSelection != null)
            {
                idCriptomoneda = criptomonedaSelection.idCriptomoneda;
                txb_Mes.Text = criptomonedaSelection.Mes.ToString();
                txb_Año.Text = criptomonedaSelection.Año.ToString();
            }
        }

        private void btn_Avanzar_Click(object sender, RoutedEventArgs e)
        {
            string respuesta0 = neBilleteraVirtual.ModificarMinadoParaTodos(0, criptomonedaSelection.Nombre);
            if (criptomonedaSelection.Mes == 12)
            {
                int auxAño = criptomonedaSelection.Año;
                int nuevoAño = auxAño + 1;
                int nuevoMes = 1;
                string respuesta1 = neCriptomoneda.ModificarMesCriptomonedaConidCriptomoneda(nuevoMes, nuevoAño, criptomonedaSelection.idCriptomoneda);
                MessageBox.Show(respuesta1);
            
            }
            else if (criptomonedaSelection.Mes < 12)
            {
                int auxMes = criptomonedaSelection.Mes;
                int nuevoMes = auxMes + 1;
                string respuesta1 = neCriptomoneda.ModificarMesCriptomonedaConidCriptomoneda(nuevoMes, criptomonedaSelection.Año, criptomonedaSelection.idCriptomoneda);
                MessageBox.Show(respuesta1);
            }

            if (criptomonedaSelection.InversionPublicidad == 0)
            {
                MessageBox.Show(" No ocurrió nada con el valor de la criptomoneda. Invierte en publicidad o seguridad para obtener resultados.");
            }
            else if (criptomonedaSelection.InversionPublicidad> 0 && criptomonedaSelection.InversionPublicidad <=500 )
            {
                if (criptomonedaSelection.Valor == 0)
                {
                    string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(Convert.ToDecimal(0.1), criptomonedaSelection.idCriptomoneda);
                    MessageBox.Show(respuesta2);
                }
                else
                {
                    decimal auxValor;
                    decimal finalValor;
                    var random = new Random();
                    var valoraelatorio = random.Next(0, 100);
                    if (valoraelatorio <=15)
                    {
                        auxValor = Convert.ToDecimal(criptomonedaSelection.Valor * Convert.ToDecimal(0.005));
                        finalValor = Convert.ToDecimal(criptomonedaSelection.Valor) - auxValor;
                        if (finalValor < 0)
                        {
                            string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(0, criptomonedaSelection.idCriptomoneda);
                            MessageBox.Show(respuesta2);
                        }
                        else
                        {
                            string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(finalValor, criptomonedaSelection.idCriptomoneda);
                            MessageBox.Show(respuesta2);
                        }
                        
                    }
                    else if (valoraelatorio>15 && valoraelatorio <=30)
                    {
                        auxValor = Convert.ToDecimal(criptomonedaSelection.Valor * Convert.ToDecimal(0.025));
                        finalValor = Convert.ToDecimal(criptomonedaSelection.Valor) - auxValor;
                        if (finalValor < 0)
                        {
                            string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(0, criptomonedaSelection.idCriptomoneda);
                            MessageBox.Show(respuesta2);
                        }
                        else
                        {
                            string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(finalValor, criptomonedaSelection.idCriptomoneda);
                            MessageBox.Show(respuesta2);
                        }

                    }
                    else if (valoraelatorio>30 && valoraelatorio <=40)
                    {
                        auxValor = Convert.ToDecimal(criptomonedaSelection.Valor * Convert.ToDecimal(0.05));
                        finalValor = Convert.ToDecimal(criptomonedaSelection.Valor) + auxValor;
                        if (finalValor < 0)
                        {
                            string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(0, criptomonedaSelection.idCriptomoneda);
                            MessageBox.Show(respuesta2);
                        }
                        else
                        {
                            string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(finalValor, criptomonedaSelection.idCriptomoneda);
                            MessageBox.Show(respuesta2);
                        }
                    }
                    else if (valoraelatorio >40 && valoraelatorio <=60)
                    {
                        auxValor = Convert.ToDecimal(criptomonedaSelection.Valor * Convert.ToDecimal(0.10));
                        finalValor = Convert.ToDecimal(criptomonedaSelection.Valor) + auxValor;
                        string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(finalValor, criptomonedaSelection.idCriptomoneda);
                        MessageBox.Show(respuesta2);
                    }
                    else if (valoraelatorio >60 && valoraelatorio <=90)
                    {
                        auxValor = Convert.ToDecimal(criptomonedaSelection.Valor * Convert.ToDecimal(0.20));
                        finalValor = Convert.ToDecimal(criptomonedaSelection.Valor) + auxValor;
                        string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(finalValor, criptomonedaSelection.idCriptomoneda);
                        MessageBox.Show(respuesta2);
                    }
                    else if (valoraelatorio>90 && valoraelatorio<=100)
                    {
                        finalValor = criptomonedaSelection.Valor;
                        string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(finalValor, criptomonedaSelection.idCriptomoneda);
                        MessageBox.Show(respuesta2);
                    }
                }
            }
            else if (criptomonedaSelection.InversionPublicidad> 500 && criptomonedaSelection.InversionPublicidad <=1000)
            {
                if (criptomonedaSelection.Valor == 0)
                {
                    string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(Convert.ToDecimal(0.1), criptomonedaSelection.idCriptomoneda);
                    MessageBox.Show(respuesta2);
                }
                else
                {
                    decimal auxValor;
                    decimal finalValor;
                    var random = new Random();
                    var valoraelatorio = random.Next(0, 100);
                    if (valoraelatorio <= 15)
                    {
                        auxValor = Convert.ToDecimal(criptomonedaSelection.Valor * Convert.ToDecimal(0.20));
                        finalValor = Convert.ToDecimal(criptomonedaSelection.Valor) - auxValor;
                        if (finalValor < 0)
                        {
                            string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(0, criptomonedaSelection.idCriptomoneda);
                            MessageBox.Show(respuesta2);
                        }
                        else
                        {
                            string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(finalValor, criptomonedaSelection.idCriptomoneda);
                            MessageBox.Show(respuesta2);
                        }

                    }
                    else if (valoraelatorio > 15 && valoraelatorio <= 30)
                    {
                        auxValor = Convert.ToDecimal(criptomonedaSelection.Valor * Convert.ToDecimal(0.65));
                        finalValor = Convert.ToDecimal(criptomonedaSelection.Valor) - auxValor;
                        if (finalValor < 0)
                        {
                            string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(0, criptomonedaSelection.idCriptomoneda);
                            MessageBox.Show(respuesta2);
                        }
                        else
                        {
                            string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(finalValor, criptomonedaSelection.idCriptomoneda);
                            MessageBox.Show(respuesta2);
                        }

                    }
                    else if (valoraelatorio > 30 && valoraelatorio <= 40)
                    {
                        auxValor = Convert.ToDecimal(criptomonedaSelection.Valor * Convert.ToDecimal(0.25));
                        finalValor = Convert.ToDecimal(criptomonedaSelection.Valor) + auxValor;
                        if (finalValor < 0)
                        {
                            string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(0, criptomonedaSelection.idCriptomoneda);
                            MessageBox.Show(respuesta2);
                        }
                        else
                        {
                            string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(finalValor, criptomonedaSelection.idCriptomoneda);
                            MessageBox.Show(respuesta2);
                        }
                    }
                    else if (valoraelatorio > 40 && valoraelatorio <= 60)
                    {
                        auxValor = Convert.ToDecimal(criptomonedaSelection.Valor * Convert.ToDecimal(0.35));
                        finalValor = Convert.ToDecimal(criptomonedaSelection.Valor) + auxValor;
                        string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(finalValor, criptomonedaSelection.idCriptomoneda);
                        MessageBox.Show(respuesta2);
                    }
                    else if (valoraelatorio > 60 && valoraelatorio <= 90)
                    {
                        auxValor = Convert.ToDecimal(criptomonedaSelection.Valor * Convert.ToDecimal(0.45));
                        finalValor = Convert.ToDecimal(criptomonedaSelection.Valor) + auxValor;
                        string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(finalValor, criptomonedaSelection.idCriptomoneda);
                        MessageBox.Show(respuesta2);
                    }
                    else if (valoraelatorio > 90 && valoraelatorio <= 100)
                    {
                        finalValor = criptomonedaSelection.Valor;
                        string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(finalValor, criptomonedaSelection.idCriptomoneda);
                        MessageBox.Show(respuesta2);
                    }
                }

            }
            else if (criptomonedaSelection.InversionPublicidad >1000 && criptomonedaSelection.InversionPublicidad <=5000)
            {
                if (criptomonedaSelection.Valor == 0)
                {
                    string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(Convert.ToDecimal(0.1), criptomonedaSelection.idCriptomoneda);
                    MessageBox.Show(respuesta2);
                }
                else
                {
                     
                    
                        decimal auxValor;
                        decimal finalValor;
                        var random = new Random();
                        var valoraelatorio = random.Next(0, 100);
                        if (valoraelatorio <= 15)
                        {
                            auxValor = criptomonedaSelection.Valor / 25;
                            finalValor = Convert.ToDecimal(criptomonedaSelection.Valor) - auxValor;
                            if (finalValor < 0)
                            {
                                string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(0, criptomonedaSelection.idCriptomoneda);
                                MessageBox.Show(respuesta2);
                            }
                            else
                            {
                                string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(finalValor, criptomonedaSelection.idCriptomoneda);
                                MessageBox.Show(respuesta2);
                            }

                        }
                        else if (valoraelatorio > 15 && valoraelatorio <= 30)
                        {
                            auxValor = Convert.ToDecimal(criptomonedaSelection.Valor/45);
                            finalValor = Convert.ToDecimal(criptomonedaSelection.Valor) - auxValor;
                            if (finalValor < 0)
                            {
                                string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(0, criptomonedaSelection.idCriptomoneda);
                                MessageBox.Show(respuesta2);
                            }
                            else
                            {
                                string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(finalValor, criptomonedaSelection.idCriptomoneda);
                                MessageBox.Show(respuesta2);
                            }

                        }
                        else if (valoraelatorio > 30 && valoraelatorio <= 40)
                        {
                            auxValor = Convert.ToDecimal(criptomonedaSelection.Valor * Convert.ToDecimal(0.55));
                            finalValor = Convert.ToDecimal(criptomonedaSelection.Valor) + auxValor;
                            if (finalValor < 0)
                            {
                                string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(0, criptomonedaSelection.idCriptomoneda);
                                MessageBox.Show(respuesta2);
                            }
                            else
                            {
                                string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(finalValor, criptomonedaSelection.idCriptomoneda);
                                MessageBox.Show(respuesta2);
                            }
                        }
                        else if (valoraelatorio > 40 && valoraelatorio <= 60)
                        {
                            auxValor = Convert.ToDecimal(criptomonedaSelection.Valor * Convert.ToDecimal(0.65));
                            finalValor = Convert.ToDecimal(criptomonedaSelection.Valor) + auxValor;
                            string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(finalValor, criptomonedaSelection.idCriptomoneda);
                            MessageBox.Show(respuesta2);
                        }
                        else if (valoraelatorio > 60 && valoraelatorio <= 90)
                        {
                            auxValor = Convert.ToDecimal(criptomonedaSelection.Valor * Convert.ToDecimal(0.75));
                            finalValor = Convert.ToDecimal(criptomonedaSelection.Valor) + auxValor;
                            string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(finalValor, criptomonedaSelection.idCriptomoneda);
                            MessageBox.Show(respuesta2);
                        }
                        else if (valoraelatorio > 90 && valoraelatorio <= 100)
                        {
                            finalValor = criptomonedaSelection.Valor;
                            string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(finalValor, criptomonedaSelection.idCriptomoneda);
                            MessageBox.Show(respuesta2);
                        }
                    
                }
            }
            else 
            {
                if (criptomonedaSelection.Valor == 0)
                {
                    string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(Convert.ToDecimal(0.1), criptomonedaSelection.idCriptomoneda);
                    MessageBox.Show(respuesta2);
                }
                else
                {
                    decimal auxValor;
                    decimal finalValor;
                    var random = new Random();
                    var valoraelatorio = random.Next(0, 100);
                    if (valoraelatorio <= 15)
                    {
                        auxValor = Convert.ToDecimal(criptomonedaSelection.Valor * Convert.ToDecimal(0.25));
                        finalValor = Convert.ToDecimal(criptomonedaSelection.Valor) - auxValor;
                        if (finalValor < 0)
                        {
                            string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(0, criptomonedaSelection.idCriptomoneda);
                            MessageBox.Show(respuesta2);
                        }
                        else
                        {
                            string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(finalValor, criptomonedaSelection.idCriptomoneda);
                            MessageBox.Show(respuesta2);
                        }

                    }
                    else if (valoraelatorio > 15 && valoraelatorio <= 30)
                    {
                        auxValor = Convert.ToDecimal(criptomonedaSelection.Valor * Convert.ToDecimal(0.5));
                        finalValor = Convert.ToDecimal(criptomonedaSelection.Valor) - auxValor;
                        if (finalValor < 0)
                        {
                            string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(0, criptomonedaSelection.idCriptomoneda);
                            MessageBox.Show(respuesta2);
                        }
                        else
                        {
                            string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(finalValor, criptomonedaSelection.idCriptomoneda);
                            MessageBox.Show(respuesta2);
                        }

                    }
                    else if (valoraelatorio > 30 && valoraelatorio <= 40)
                    {
                        auxValor = Convert.ToDecimal(criptomonedaSelection.Valor * Convert.ToDecimal(0.85));
                        finalValor = Convert.ToDecimal(criptomonedaSelection.Valor) + auxValor;
                        if (finalValor < 0)
                        {
                            string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(0, criptomonedaSelection.idCriptomoneda);
                            MessageBox.Show(respuesta2);
                        }
                        else
                        {
                            string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(finalValor, criptomonedaSelection.idCriptomoneda);
                            MessageBox.Show(respuesta2);
                        }
                    }
                    else if (valoraelatorio > 40 && valoraelatorio <= 60)
                    {
                        auxValor = Convert.ToDecimal(criptomonedaSelection.Valor * Convert.ToDecimal(0.95));
                        finalValor = Convert.ToDecimal(criptomonedaSelection.Valor) + auxValor;
                        string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(finalValor, criptomonedaSelection.idCriptomoneda);
                        MessageBox.Show(respuesta2);
                    }
                    else if (valoraelatorio > 60 && valoraelatorio <= 90)
                    {
                        auxValor = Convert.ToDecimal(criptomonedaSelection.Valor * Convert.ToDecimal(1));
                        finalValor = Convert.ToDecimal(criptomonedaSelection.Valor) + auxValor;
                        string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(finalValor, criptomonedaSelection.idCriptomoneda);
                        MessageBox.Show(respuesta2);
                    }
                    else if (valoraelatorio > 90 && valoraelatorio <= 100)
                    {
                        finalValor = criptomonedaSelection.Valor;
                        string respuesta2 = neCriptomoneda.ModificarValorCriptomonedaConidCriptomoneda(finalValor, criptomonedaSelection.idCriptomoneda);
                        MessageBox.Show(respuesta2);
                    }
                }
            }
            dgEmpleos.ItemsSource = neCriptomoneda.ListarCriptomonedaDelCreador(neCreador.BuscarIdCreadorConCodigoEspecial(Convert.ToInt32(txb_CodigoEspecial.Text)));
            MessageBox.Show(respuesta0);


        }

        private void btn_CerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            SesionCreador s = new SesionCreador();
            s.Show();
            this.Close();
        }

        private void btn_Editar_Click(object sender, RoutedEventArgs e)
        {
            WpfEditarDatosCreador wpfEditarDatosCreador = new WpfEditarDatosCreador();
            wpfEditarDatosCreador.Show();
            this.Close();

        }

        private void btn_VerCriptomonedasObtenidas_Click(object sender, RoutedEventArgs e)
        {
            WpfBilleteraCreador wpfBilleteraCreador = new WpfBilleteraCreador();
            wpfBilleteraCreador.Show();
            Close();
        }

        private void tbn_Transferencias_Click(object sender, RoutedEventArgs e)
        {
            WpfTransferencia wpfTransferencia = new WpfTransferencia();
            bool aux = false;
            var random = new Random();
            var valoraelatorio = random.Next(0, 9999);
            while (aux == true)
            {
                aux = neCreador.YaExisteCodigoEspecial(valoraelatorio);
            }
            if (txb_CodigoEspecial.Text != "")
            {
                neCreador.ModificarCodigoEspecialConCodigoEspecial(valoraelatorio, Convert.ToInt32(txb_CodigoEspecial.Text));
                MessageBox.Show("Su código de encriptación temporal es: " + valoraelatorio.ToString());
                wpfTransferencia.Show();
                Close();
            }
            else
            {
                MessageBox.Show(" Digite su código especial. No puede dejar espacios en blanco. ");
            }
            

        }

        private void txb_Mes_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_Ayuda_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bienevido a su sesión. Ingrese su número de PIN brindado por su hardware. Se utiliza por motivos de seguridad para evitar robos o pérdidas. Pueda crear su criptomoneda, minarla, comprar, etc. ¡Diviértase!");
        }
    }
}
