using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
                MessageBox.Show("Erro ao iniciar comunicação","ERRO",MessageBoxButton.OK);

            if (Protocolo1.IsChecked == true)
                retorno = Funcoes_Bematech.Bematech_FIT_SelecionaProtocolo(1);
            else
                retorno = Funcoes_Bematech.Bematech_FIT_SelecionaProtocolo(0);
        }

        private void FComunicacao_Click(object sender, RoutedEventArgs e)
        {
            int retorno;
            retorno = Funcoes_Bematech.Bematech_FIT_FechaComunicacao();

            if (retorno == 0)
                MessageBox.Show("Erro ao fechar comunicação", "ERRO", MessageBoxButton.OK);
        }

        private void VFirmware_Click(object sender, RoutedEventArgs e)
        {
            int retorno;
            char temp='0';
            string buffer;

            retorno = Funcoes_Bematech.Bematech_FIT_VersaoFirmware(Convert.ToChar(Terminal.Text));

            if (retorno == 0)
                MessageBox.Show("Erro ao obter firmware", "ERRO", MessageBoxButton.OK);
            else
            {
                buffer = "";

                //Fazer o cast do char -(char)- é equivalente ao método Chr em VB
                while (temp != (char)3) {
                    Thread.Sleep(100);
                    temp = Funcoes_Bematech.Bematech_FIT_LerBuffer(Convert.ToChar(Terminal.Text));
                    buffer += temp;
                };

                InfFirmware.Items.Add(buffer);
            }
        }
    }
}
