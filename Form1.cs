using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.IO;
namespace RPM
{
    public partial class Form1 : Form
    { 
        
        public Form1()
        {

            using (System.IO.StreamReader file = new System.IO.StreamReader(@".\ServerList.txt"))
            InitializeComponent();
            Serverlist.Items.AddRange(File.ReadAllLines(@".\ServerList.txt"));
            PingTimer.Interval = 900000;           
            this.Text = "RPM - 0.2";
            

        }



        private void UpdateInfo_Click(object sender, EventArgs e)
        {
                  
            ServersListBox.Items.Clear();

            Ping ping = new Ping();

            LastUpdate.Text = "Last Update: " + DateTime.Now;

            foreach (string i in Serverlist.Items)
            {
               
                try
                {

                    ServersListBox.Items.Add("Host Name:  " + i);
                    ServersListBox.Items.Add("Connection:  " + ping.Send(i).Status);
                    ServersListBox.Items.Add("IP Address:  " + ping.Send(i).Address);
                    ServersListBox.Items.Add("");

                }
                catch (System.Net.Sockets.SocketException)
                {
                    
                    ServersListBox.Items.Add("Connection:  Failed");
                    ServersListBox.Items.Add("IP Address:  " + ping.Send(i).Address);
                    ServersListBox.Items.Add("");
                    
                }

                catch (System.Net.NetworkInformation.PingException)
                {
                    
                    ServersListBox.Items.Add("Connection:  Failed");
                    ServersListBox.Items.Add("IP Address:  Failed");
                    ServersListBox.Items.Add("");
                
                }

                catch (System.ArgumentNullException)
                {
                   
                    ServersListBox.Items.Add("Connection:  Blank Host Name");
                    ServersListBox.Items.Add("IP Address:  Blank Host Name");
                    ServersListBox.Items.Add("");

                }
                

            }
            


        }

        private void AddServer_Click(object sender, EventArgs e)
        {

            if (ServerTextBox.Text == "")

            {
                Serverlist.Items.Add("Host Name Blank");
                
            }
            else
            {
                Serverlist.Items.Add(ServerTextBox.Text);
            }

            ServerTextBox.Clear();

        }

        private void RemoveServer_Click(object sender, EventArgs e)
        {
            Serverlist.Items.Remove(Serverlist.SelectedItem);
        }

        private void PingTimer_Tick(object sender, EventArgs e)
        {


            ServersListBox.Items.Clear();

            Ping ping = new Ping();
            
            LastUpdate.Text = "Last Update: " + DateTime.Now;

            foreach (string i in Serverlist.Items)
            {
               

                try
                {

                    ServersListBox.Items.Add("Host Name:  " + i);
                    ServersListBox.Items.Add("Connection:  " + ping.Send(i).Status);
                    ServersListBox.Items.Add("IP Address:  " + ping.Send(i).Address);
                    ServersListBox.Items.Add("");

                }
                catch (System.Net.Sockets.SocketException)
                {

                    ServersListBox.Items.Add("Connection:  Failed");
                    ServersListBox.Items.Add("IP Address:  " + ping.Send(i).Address);
                    ServersListBox.Items.Add("");

                }

                catch (System.Net.NetworkInformation.PingException)
                {

                    ServersListBox.Items.Add("Connection:  Failed");
                    ServersListBox.Items.Add("IP Address:  Failed");
                    ServersListBox.Items.Add("");

                }

                catch (System.ArgumentNullException)
                {
                   
                    ServersListBox.Items.Add("Connection:  Blank Host Name");
                    ServersListBox.Items.Add("IP Address:  Blank Host Name");
                    ServersListBox.Items.Add("");

                }
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@".\ServerList.txt", false))

                if (Serverlist.Items.Count > 0)
                {
                    for (int i = 0; i < Serverlist.Items.Count; i++)
                    {

                        file.WriteLine(Serverlist.Items[i].ToString());

                    };

                }
        }

        private void UpdateFreqBtn_Click(object sender, EventArgs e)
        {
            
            int Value = int.Parse(UpdateFreqTB.Text);
            UpdateFreqBtn.Text = "Update Freq (" + Value + " mins)";
            PingTimer.Interval = (Value * 60000);
        }
    }
}
