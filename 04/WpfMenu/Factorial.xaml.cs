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

namespace WpfMenu
{
    /// <summary>
    /// Interaction logic for Factorial.xaml
    /// </summary>
    public partial class Factorial : Window
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, RoutedEventArgs e)
        {
            int n = 0;
            
            try {
                n = Convert.ToInt32(tbValor.Text);
                
                if(n > 0)
                {
                    int t = n;
                    for(int i = n-1; i > 0; i--)
                    {
                        t = t * i;
                    }
                    MessageBox.Show("Factorial do numero " + n.ToString() + " é " + t.ToString());
                } else
                {
                    if(n == 0) MessageBox.Show("Factorial do numero " + n.ToString() + " é 1");
                    else MessageBox.Show("Informe apenas numeros positivos");
                }
            } catch
            {
                MessageBox.Show("Informe apenas numeros positivos");
            }
        }
    }
}
