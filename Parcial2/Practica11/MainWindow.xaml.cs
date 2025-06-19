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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practica11
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Storyboard sb1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btinicio_Click(object sender, RoutedEventArgs e)
        {
            sb1 = (Storyboard)FindResource("Storyboard1");
            sb1.Begin();
        }

        private void btstop_Click(object sender, RoutedEventArgs e)
        {
            sb1.Stop();
        }

        private void btpause_Click(object sender, RoutedEventArgs e)
        {
            sb1.Pause();
        }

        private void btresume_Click(object sender, RoutedEventArgs e)
        {
            sb1.Resume();
        }
    }
}
