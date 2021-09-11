﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_SesionCreador_Click(object sender, RoutedEventArgs e)
        {
            SesionCreador sesionCreador = new SesionCreador();
            sesionCreador.Show();
            this.Close();
        }

        private void btn_SesionInversionista_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
