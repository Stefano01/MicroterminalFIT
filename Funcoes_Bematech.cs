using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MicroTerminalFIT
{
    public class Funcoes_Bematech
    {
        [DllImport("BemaSB32.dll")]
        public static extern int Bematech_FIT_IniciaComunicacao ();

        [DllImport("BemaSB32.dll")]
        public static extern int Bematech_FIT_FechaComunicacao ();

        //Parametro protocolo
        [DllImport("BemaSB32.dll")]
        public static extern int Bematech_FIT_SelecionaProtocolo (int protocolo);

        //Parametro terminal
        [DllImport("BemaSB32.dll")]
        public static extern int Bematech_FIT_LimpaDisplay(char terminal);

        //Parametro terminal
        [DllImport("BemaSB32.dll")]
        public static extern int Bematech_FIT_EscreveDisplay(char terminal);

        //Parametros terminal, linha, coluna
        [DllImport("BemaSB32.dll")]
        public static extern int Bematech_FIT_PosicionaCursor(char terminal, char linha, char coluna);

        //Parametros terminal
        [DllImport("BemaSB32.dll")]
        public static extern char Bematech_FIT_LerBuffer(char terminal);

        //Parametros terminal, dados, serial
        [DllImport("BemaSB32.dll")]
        public static extern int Bematech_FIT_EnviaSerial(char terminal, char dados, char serial);

        //Parametros terminal
        [DllImport("BemaSB32.dll")]
        public static extern int Bematech_FIT_ApagaLinha(char terminal);

        //Parametros terminal
        [DllImport("BemaSB32.dll")]
        public static extern int Bematech_FIT_DeslocaCursorCima(char terminal);

        //Parametros terminal
        [DllImport("BemaSB32.dll")]
        public static extern int Bematech_FIT_DeslocaCursorDireita(char terminal);

        //Parametros terminal
        [DllImport("BemaSB32.dll")]
        public static extern int Bematech_FIT_VersaoFirmware(char terminal);

        //Parametros terminal, comando
        [DllImport("BemaSB32.dll")]
        public static extern int Bematech_FIT_ComandoGenerico(char terminal, char comando);

        //Parametros terminal
        [DllImport("BemaSB32.dll")]
        public static extern int Bematech_FIT_LeituraCodidoBarras(char terminal);

        //Parametros comando
        [DllImport("BemaSB32.dll")]
        public static extern int Bematech_FIT_EnviaComando(string comando);
    }
}
