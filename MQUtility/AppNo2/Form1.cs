using System;
using System.Windows.Forms;
using TestDomain;

namespace AppNo2
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
          
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            _mqPool.InitRcv("AppNo2", obj =>
            {
                var msg = obj as Msg;
                Invoke(new Action(() => {
                    rtxt_ShowMqInfo.Text = msg.Content;
                }));

              
            });
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            _mqPool.Send("AppNo1", new Msg("AppNo2", txt_Send.Text));
        }
    }
}
