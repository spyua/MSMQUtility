using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestDomain;

namespace AppNo1
{
    public partial class Form1 : Form
    {
        private IMQPool _mqPool;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _mqPool = new MQPool();
            _mqPool.InitRcv("AppNo1", obj =>
            {
                var msg = obj as Msg;
                Invoke(new Action(() => {
                    rtxt_ShowMqInfo.Text = msg.Content;
                }));
            });
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            _mqPool.Send("AppNo2", new Msg("AppNo1", txt_Send.Text));
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            rtxt_ShowMqInfo.Clear();
        }
    }
}
