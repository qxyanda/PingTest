using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool stop = false;
        private void btn_start_Click(object sender, EventArgs e)
        {
            stop = false;
            string ip = "172.17.0.";
            int test = 13;
            for (test = 13; test < 15; test++)
            {
                if (stop) break;
                if (Ping(ip + test.ToString()))
                {
                    tb_msg.AppendText(ip + test.ToString() + ":ok!" + "\r\n");
                }
                else
                {
                    tb_error.AppendText(ip + test.ToString() + ":no ok!" + "\r\n");
                }
            }
            for (test = 20; test < 58; test++)
            {
                if (stop) break;
                if (Ping(ip + test.ToString()))
                {
                    tb_msg.AppendText(ip + test.ToString() + ":ok!" + "\r\n");
                }
                else
                {
                    tb_error.AppendText(ip + test.ToString() + ":no ok!" + "\r\n");
                }
            }
        }

        /// <summary>
        /// 是否能 Ping 通指定的主机
        /// </summary>
        /// <param name="ip">ip 地址或主机名或域名</param>
        /// <returns>true 通，false 不通</returns>
        public bool Ping(string ip)
        {
            System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping();
            System.Net.NetworkInformation.PingOptions options = new System.Net.NetworkInformation.PingOptions();
            options.DontFragment = true;
            string data = "Test Data!";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 1000; // Timeout 时间，单位：毫秒
            System.Net.NetworkInformation.PingReply reply = p.Send(ip, timeout, buffer, options);
            if (reply.Status == System.Net.NetworkInformation.IPStatus.Success)
                return true;
            else
                return false;
        }

        private void btn_single_Click(object sender, EventArgs e)
        {
            string ip = tb_ip.Text;

            if (Ping(ip))
            {
                tb_msg.AppendText(ip + ":ok!" + "\r\n");
            }
            else
            {
                tb_error.AppendText(ip + ":no ok!" + "\r\n");
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            stop = true;
        }
    }
}
