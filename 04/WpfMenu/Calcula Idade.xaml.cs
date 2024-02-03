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
    /// Interaction logic for Calcula_Idade.xaml
    /// </summary>
    public partial class Calcula_Idade : Window
    {
        public Calcula_Idade()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, RoutedEventArgs e)
        {
            DateTime dn = (DateTime) datNasc.SelectedDate;
            //DateTime da = (DateTime) datAct.SelectedDate;
            
            DateTime da = DateTime.Now;

            int idade = da.Year - dn.Year;
            tbIdade.Text = idade.ToString();
        }
    }
}
