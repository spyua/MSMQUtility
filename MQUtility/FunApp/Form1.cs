using MQUtility;
using System;
using System.Timers;
using System.Windows.Forms;
using TestDomain;

namespace FunApp
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer _tmrSend;
        private IMQPool _mqPool;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _mqPool = new MQPool(SystemMQ.FunApp).AddObjectMQ(SystemMQ.RcvApp);
            _tmrSend = new System.Timers.Timer(200);
            _tmrSend.Elapsed += DisplayMQCnt;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            _tmrSend.Start();
        }

        private void DisplayMQCnt(object sender, ElapsedEventArgs e)
        {
            var mqCnt = _mqPool.GetCount(SystemMQ.FunApp);
            Invoke(new Action(() => {
                MqCntLabel.Text = mqCnt.ToString();
            }));
        }

        private void ClearAllMQBtn_Click(object sender, EventArgs e)
        {
            _mqPool.Clear(SystemMQ.FunApp);
        }

        private void MQRemoveFirstBtn_Click(object sender, EventArgs e)
        {
            _mqPool.RemoveFirst(SystemMQ.FunApp);
        }
    }
}
