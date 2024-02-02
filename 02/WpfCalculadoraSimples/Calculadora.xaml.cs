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

namespace WpfCalculadoraSimples
{
    /// <summary>
    /// Interaction logic for Calculadora.xaml
    /// </summary>
    public partial class Calculadora : Window
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btMenos_Click(object sender, RoutedEventArgs e)
        {
            Double a = Convert.ToDouble(tbValorA.Text);
            Double b = Convert.ToDouble(tbValorB.Text);

            Double c = a - b;
            tbResultado.Text = a.ToString() + " - " + b.ToString() + " = " + c.ToString();
        }

        private void btMais_Click(object sender, RoutedEventArgs e)
        {
            Double a = Convert.ToDouble(tbValorA.Text);
            Double b = Convert.ToDouble(tbValorB.Text);

            Double c = a + b;
            tbResultado.Text = a.ToString() + " + " + b.ToString() + " = " + c.ToString();
        }

        private void btMulti_Click(object sender, RoutedEventArgs e)
        {
            Double a = Convert.ToDouble(tbValorA.Text);
            Double b = Convert.ToDouble(tbValorB.Text);

            Double c = a * b;
            tbResultado.Text = a.ToString() + " * " + b.ToString() + " = " + c.ToString();
        }

        private void btDivisao_Click(object sender, RoutedEventArgs e)
        {
            Double a = Convert.ToDouble(tbValorA.Text);
            Double b = Convert.ToDouble(tbValorB.Text);

            Double c = a / b;
            tbResultado.Text = a.ToString() + " / " + b.ToString() + " = " + c.ToString();
        }
    }
}
