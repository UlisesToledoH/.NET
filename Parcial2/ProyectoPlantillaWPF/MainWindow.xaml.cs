﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

namespace ProyectoPlantillaWPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Supongamos que tienes un TextBox llamado "textBox" y un ListBox llamado "listBox" en tu interfaz.

            double x, r;
            x = double.Parse(Textbox.Text);
            r = Math.Exp(x);
            listbox.Items.Add(r);

        }

        private void Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        { 
        }
        private void SalirMenuItem_Click(object sender, RoutedEventArgs e) { 
         Application.Current.Shutdown();
        }
        private void FirmaMenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("FIRMA.exe");
        }
    }
}
