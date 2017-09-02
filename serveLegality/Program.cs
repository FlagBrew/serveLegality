using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using PKHeX.Core;
using System.Text;
using System.Windows.Forms;

namespace serveLegality
{
    class Program
    {
        private const int PKSIZE = 232;
        private const String HEADER = "PKSMOTA";
        private const int GAME_LEN = 1;
        private const int GEN6 = 6;
        private const int GEN7 = 7;
        private const string MGDatabasePath = "mgdb";

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new serveLegalityGUI());
        }
    }
}
