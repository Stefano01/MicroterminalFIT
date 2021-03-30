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
        public static extern int Bematech_FIT_LimpaDisplay(byte terminal);

        //Parametro terminal
        [DllImport("BemaSB32.dll")]
        public static extern int Bematech_FIT_EscreveDisplay(byte terminal);

        //Parametros terminal, linha, coluna
        [DllImport("BemaSB32.dll")]
        public static extern int Bematech_FIT_PosicionaCursor(byte terminal, byte linha, byte coluna);

        //Parametros terminal
        [DllImport("BemaSB32.dll")]
        public static extern int Bematech_FIT_LerBuffer(byte terminal);

        //Parametros terminal, dados, serial
        [DllImport("BemaSB32.dll")]
        public static extern int Bematech_FIT_EnviaSerial(byte terminal, byte dados, byte serial);

        //Parametros terminal
        [DllImport("BemaSB32.dll")]
        public static extern int Bematech_FIT_ApagaLinha(byte terminal);

        //Parametros terminal
        [DllImport("BemaSB32.dll")]
        public static extern int Bematech_FIT_DeslocaCursorCima(byte terminal);

        //Parametros terminal
        [DllImport("BemaSB32.dll")]
        public static extern int Bematech_FIT_DeslocaCursorDireita(byte terminal);

        //Parametros terminal
        [DllImport("BemaSB32.dll")]
        public static extern int Bematech_FIT_VersaoFirmware(byte terminal);

        //Parametros terminal, comando
        [DllImport("BemaSB32.dll")]
        public static extern int Bematech_FIT_ComandoGenerico(byte terminal, byte comando);

        //Parametros terminal
        [DllImport("BemaSB32.dll")]
        public static extern int Bematech_FIT_LeituraCodidoBarras(byte terminal);

        //Parametros comando
        [DllImport("BemaSB32.dll")]
        public static extern int Bematech_FIT_EnviaComando(string comando);
    }
}
