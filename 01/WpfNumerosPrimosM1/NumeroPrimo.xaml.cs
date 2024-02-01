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

namespace WpfNumerosPrimosM1
{
    /// <summary>
    /// Interaction logic for NumeroPrimo.xaml
    /// </summary>
    public partial class NumeroPrimo : Window
    {
        public NumeroPrimo()
        {
            InitializeComponent();
        }

        private void tbValor_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btExecutar_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(tbValor.Text);

            if(FerramentasMagicas.VerificaNumeroPrimo(n) == true)
            {
                lbResult.Content = "O numero informado representa um numero primo";
            } else
            {
                lbResult.Content = "O numero informado nao representa um numero primo";
            }
        }
    }
}
