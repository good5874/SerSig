using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetCoreServer;
using Newtonsoft.Json;
using SerSig.CustomNetCoreServer;

namespace SerSig
{
    public partial class FrmServer : Form
    {
        #region ОБЪЯВЛЕНИЯ
        public string ServerIP = "localhost";
        ChatServer server;
        //ChatSession session;
        int port = 54000;

        public string IpAdressClient = "";
        public string CountryClient = "";
        public string CityClient = "";
        public string CountryCity = "";
        public string Session = "";
        public string SessionTemp = "";
        public string SessionConnect = "";
        public string SessionDisconnect = "";
        public bool flagServerStart = false;
        TextWriter _writerTBConnect = null;
        public static int rowIndex = -1;
        public static int rowIndexTemp = -1;

        #endregion

        public FrmServer()
        {
            InitializeComponent();
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
        }

        private void FrmServer_Shown(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)(() =>{  }));
            tbSignal.Text = "";
            btnStart.Enabled = true;
            txtSignal.Enabled = false;
            txtCountClient.Text = "Ожидание подключений...";
        }

        private  void btnStart_Click(object sender, EventArgs e)
        {
            StartServer();
            txtServerStatus.Text = "Подключен";
        }

        private async void StartServer()
        {
            server = new ChatServer(IPAddress.Any, port);
            //session = new ChatSession(server);
            server.Start();
            btnStart.Enabled = false;
            flagServerStart = true;


            await Task.Delay(10);
        }

        private async void ReadClientSession()
        {
            await Task.Run(() =>
            {
                if (txtSessionConnect.Text == "") { return; }
                else if (txtSessionConnect.Text != "")
                {
                    while (true)
                    {
                        if (txtSessionConnect.Text == txtSessionTemp.Text) { return; }
                        else if (txtSessionConnect.Text != txtSessionTemp.Text)
                        {
                            txtSessionTemp.Text = txtSessionConnect.Text;
                            Session = txtSessionTemp.Text;
                            if (Session.Contains("+"))
                            {
                                Invoke(new Action(async () =>
                                {
                                    SessionConnect = Session.Substring(1, Session.IndexOf("*")-1);
                                    IpAdressClient = txtSessionConnect.Text.Substring(txtSessionConnect.Text.IndexOf("*") + 1, txtSessionConnect.Text.IndexOf("@") - txtSessionConnect.Text.IndexOf("*") - 1);
                                    CountryClient = ChatSession.GetUserCountryByIp(IpAdressClient);
                                    CityClient = ChatSession.GetUserCityByIp(IpAdressClient);
                                    //Debug.WriteLine($"SessionConnect = {SessionConnect}");
                                    String[] row = { SessionConnect, IpAdressClient, CountryClient, CityClient };
                                    ListViewItem item = new ListViewItem(row);
                                    lvClients.Items.Add(item);
                                    txtCountClient.Text = lvClients.Items.Count.ToString();
                                    txtSessionConnect.Text = "";
                                    await Task.Delay(100);
                                    return;
                                }));
                                return;
                            }
                            else if (Session.Contains("-"))
                            {
                                Invoke(new Action(async () =>
                                {
                                    SessionDisconnect = Session.Substring(1).Trim();
                                    for (int i = 0; i < lvClients.Items.Count; i++)
                                    {
                                        lvClients.Items[i].Selected = false;
                                        if (lvClients.Items[i].Text != null)
                                        {
                                            if (lvClients.Items[i].Text.ToString() == SessionDisconnect)
                                            {
                                                lvClients.Items[i].Selected = true;
                                                lvClients.Items.RemoveAt(i);
                                                break;
                                            }
                                        }
                                    }
                                    txtCountClient.Text = lvClients.Items.Count.ToString();
                                    txtSessionConnect.Text = "";
                                    await Task.Delay(100);
                                    return;
                                }));
                                return;
                            }
                        }
                    }
                }
            });
        }

        private void tmrClient_Tick(object sender, EventArgs e)
        {
            //_writerTBConnect = new TBStreamWriterConnect(txtSessionConnect);
            //Console.SetOut(_writerTBConnect);
            //ReadClientSession();
        }



        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (flagServerStart == false)
            {
                tmrClient.Stop();
                System.Environment.Exit(1);
                Application.Exit();
            }
            else if (flagServerStart == true)
            {
                tmrClient.Stop();
                server.Stop();
                System.Environment.Exit(1);
                Application.Exit();
            }
        }
    }
}