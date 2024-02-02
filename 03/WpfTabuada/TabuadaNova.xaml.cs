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

namespace WpfTabuada
{
    /// <summary>
    /// Interaction logic for TabuadaNova.xaml
    /// </summary>
    public partial class TabuadaNova : Window
    {
        public TabuadaNova()
        {
            InitializeComponent();
        }

        private void btExecutar_Click(object sender, RoutedEventArgs e)
        {
            if (lbResposta != null)
            {
                int n = cbNumero.SelectedIndex + 1;
                int res = 0;

                lbResposta.Items.Clear();

                for (int i = 0; i <= 12; i++)
                {
                    res = n * i;
                    ListBoxItem it = new ListBoxItem();
                    it.Content = n.ToString() + " x " + i.ToString() + " = " + res.ToString();
                    lbResposta.Items.Add(it);
                }
            }
        }

        private void cbNumero_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btExecutar_Click(sender, e);
        }
    }
}
