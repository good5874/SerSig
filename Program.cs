using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using NetCoreServer;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SerSig
{
    public partial class Program : Form
    {
        public static FrmServer frmServer;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmServer = new FrmServer();
            Application.Run(frmServer);
        }
    }

    public static class Data
    {
        public static string ValueIpClient { get; set; }
        public static string ValueSessionClient { get; set; }
        public static int ValueCountClient { get; set; }
    }
}
