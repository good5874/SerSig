using NetCoreServer;
using Newtonsoft.Json;
using SerSig.CustomNetCoreServer.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerSig.CustomNetCoreServer
{
    public class ChatSession : TcpSession
    {
        public List<string> Errors;
        public List<string> Messages;

        private string ConnectSession;
        private string IpAdressClient;
        private string CountryClient;
        private string CityClient;

        public delegate void AddItemDelegate(ListViewItem item);
        public delegate void DeleteItemDelegate(Guid id);


        public ChatSession(TcpServer server) : base(server)
        {
            Errors = new List<string>();
            Messages = new List<string>();
        }

        protected override void OnConnected()
        {
            try
            {
                TcpSession session = Server.FindSession(Id);
                string clientIP = session.Socket.RemoteEndPoint.ToString();
                ConnectSession = Id.ToString();
                IpAdressClient = IpClient.Substring(0, IpClient.IndexOf(":"));
                CountryClient = GetUserCountryByIp(IpAdressClient);
                CityClient = GetUserCityByIp(IpAdressClient);

                string[] row = { ConnectSession, IpAdressClient, CountryClient, CityClient };
                ListViewItem item = new ListViewItem(row);
                Program.frmServer.lvClients.BeginInvoke(new AddItemDelegate(DelegateAddItem), item);

                Messages.Add("+" + Id + "*" + IpAdressClient + "@" + CountryClient + "#" + CityClient);
            }
            catch(Exception e)
            {
                Errors.Add($"Error conection: {e.Message}");
            }
        }
        private void DelegateAddItem(ListViewItem item)
        {
            Program.frmServer.lvClients.Items.Add(item);
        }

        private void DelegatDeleteItem(Guid id)
        {
            for(int i=0;i< Program.frmServer.lvClients.Items.Count; i++)
            {
                if(Program.frmServer.lvClients.Items[i].Text == id.ToString())
                {
                    Program.frmServer.lvClients.Items.RemoveAt(i);
                    return;
                }
            }
        }

        protected override void OnDisconnected()
        {
            Messages.Add("-" + Id);
            Program.frmServer.lvClients.BeginInvoke(new DeleteItemDelegate(DelegatDeleteItem), Id);
        }

        protected override void OnReceived(byte[] buffer, long offset, long size)
        {
            string message = Encoding.UTF8.GetString(buffer, (int)offset, (int)size);
            Messages.Add($"message: {message}");
        }

        protected override void OnError(SocketError error)
        {
            Errors.Add($"Chat TCP session caught an error with code {error}");
        }

        public static string GetUserCountryByIp(string ip)
        {
            IpInfo ipInfo = new IpInfo();
            try
            {
                string info = new WebClient().DownloadString("http://ipinfo.io/" + ip);
                ipInfo = JsonConvert.DeserializeObject<IpInfo>(info);
                RegionInfo myRI1 = new RegionInfo(ipInfo.Country);
                ipInfo.Country = myRI1.EnglishName;
            }
            catch (Exception)
            {
                ipInfo.Country = null;
            }
            return ipInfo.Country;
        }

        public static string GetUserCityByIp(string ip)
        {
            IpInfo ipInfo = new IpInfo();
            try
            {
                string info = new WebClient().DownloadString("http://ipinfo.io/" + ip);
                ipInfo = JsonConvert.DeserializeObject<IpInfo>(info);
                RegionInfo myRI1 = new RegionInfo(ipInfo.City);
                ipInfo.Country = myRI1.EnglishName;
            }
            catch (Exception)
            {
                ipInfo.Country = null;
            }
            return ipInfo.City;
        }
    }
}
