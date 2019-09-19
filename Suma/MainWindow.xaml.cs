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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Suma
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
            int numero1 = int.Parse(txtprimernumero.Text);
            int numero2 = int.Parse(txtsegundonumero.Text);
            int resultado = numero1 + numero2;
            lblbresultado.Text = resultado.ToString();
        }

        private void Resta_Click(object sender, RoutedEventArgs e)
        {
            

        }
    }
}

