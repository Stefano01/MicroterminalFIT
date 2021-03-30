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

namespace MicroTerminalFIT
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

        private void IComunicacao_Click(object sender, RoutedEventArgs e)
        {
            int retorno;
            retorno = Funcoes_Bematech.Bematech_FIT_IniciaComunicacao();

            if (retorno == 0)
            {
                MessageBox.Show("Erro de iniciar comunicação");
            }
        }

        private void FComunicacao_Click(object sender, RoutedEventArgs e)
        {
            int retorno;
            retorno = Funcoes_Bematech.Bematech_FIT_FechaComunicacao();

            if (retorno == 0)
            {
                MessageBox.Show("Erro ao fechar comunicação");
            }
        }
    }
}
