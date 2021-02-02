using System;
using System.Timers;
using System.Windows.Forms;
using TestDomain;

namespace AppTestMQRead
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer _tmrSend;
        private IMQPool _mqPool;
        private string _mqName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
           
            
            _mqName = "AppTestMQRead";
            _mqPool = new MQPool(_mqName);
            _tmrSend = new System.Timers.Timer(200);

        }

        private void Form1_Shown(object sender, System.EventArgs e)
        {

            _tmrSend.Elapsed += DisplayMQCnt;
            _tmrSend.Start();

        }

        private void DisplayMQCnt(object sender, ElapsedEventArgs e)
        {
            var mqCnt = _mqPool.GetCount(_mqName);
            Invoke(new Action(() => {
                MqCntLabel.Text = mqCnt.ToString();
            }));
        }

        private void ClearAllMQBtn_Click(object sender, EventArgs e)
        {
            _mqPool.Clear(_mqName);
        }

        private void MQRemoveFirstBtn_Click(object sender, EventArgs e)
        {
            _mqPool.(_mqName);
        }

        private void lbl_PendingMqCnt_Click(object sender, EventArgs e)
        {

        }

        private void MqCntLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
