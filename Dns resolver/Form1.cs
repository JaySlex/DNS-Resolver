using System;
using System.Net;
using System.Windows.Forms;

namespace Dns_resolver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            try
            {
                IPAddress[] ips = Dns.GetHostAddresses(textBox1.Text);
                foreach (IPAddress item in ips)
                {
                    textBox2.Text += "\n"+item.MapToIPv4().ToString();
                }
            }
            catch(Exception ex)
            {
                textBox2.Text = ex.Message;
            }
        }
    }
}
