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

namespace WpfMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void imTabuada_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Tabuada();
            w.Show(); //Permite criar novas janelas
            //w.ShowDialog(); //Nao permite clicar nova janela enquanto utilizado
        }

        private void imFactorial_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Factorial();
            w.Show();
        }

        private void imIdade_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Calcula_Idade();
            w.Show();
        }
    }
}
