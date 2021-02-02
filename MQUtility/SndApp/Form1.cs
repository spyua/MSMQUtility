using MQUtility;
using System;
using System.Timers;
using System.Windows.Forms;
using TestDomain;

namespace SndApp
{
    public partial class SndAppForm : Form
    {
        private System.Timers.Timer _tmrSend;

        private IMQPool _mqPool;
        public SndAppForm()
        {
            InitializeComponent();
        }

        private void SndAppForm_Load(object sender, EventArgs e)
        {
            _mqPool = new MQPool(SystemMQ.SndApp).AddObjectMQ(SystemMQ.RcvApp).AddObjectMQ(SystemMQ.FunApp);
            _tmrSend = new System.Timers.Timer(10);
            _tmrSend.Elapsed += SndRcvApp;
        }

        private void SndAppForm_Shown(object sender, EventArgs e)
        {
          
        }

        private void SndRcvApp(object sender, ElapsedEventArgs e)
        {
            _mqPool.Send(SystemMQ.RcvApp, new DomainMsg(SystemMQ.SndApp, txt_Send.Text));
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            _tmrSend.Stop();
            _mqPool.Send(SystemMQ.RcvApp, new DomainMsg(SystemMQ.SndApp, txt_Send.Text));
            _mqPool.Send(SystemMQ.FunApp, new DomainMsg(SystemMQ.SndApp, txt_Send.Text));
        }

        private void SpeedlySndBtn_Click(object sender, EventArgs e)
        {
            _tmrSend.Start();
        }

        
    }
}
