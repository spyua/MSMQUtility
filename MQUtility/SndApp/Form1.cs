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
            _mqPool = MQPool.Instance.AddMQ(SystemMQ.SndApp, SystemMQ.RcvApp, SystemMQ.FunApp);
            _tmrSend = new System.Timers.Timer(10);
            _tmrSend.Elapsed += SndRcvApp;
        }

        private void SndAppForm_Shown(object sender, EventArgs e)
        {
          
        }

        private void SndRcvApp(object sender, ElapsedEventArgs e)
        {
            TryFlow(() =>
            {
                _mqPool.SendMsg(SystemMQ.RcvApp, new DomainMsg(SystemMQ.SndApp, txt_Send.Text));
            });
          
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            _tmrSend.Stop();

            TryFlow(() =>
            {
                _mqPool.SendMsg(SystemMQ.RcvApp, new DomainMsg(SystemMQ.SndApp, txt_Send.Text));
                _mqPool.SendMsg(SystemMQ.FunApp, new DomainMsg(SystemMQ.SndApp, txt_Send.Text));
            });
          
           
        }

        private void SpeedlySndBtn_Click(object sender, EventArgs e)
        {
            _tmrSend.Start();
        }

        private void TryFlow(Action action, bool @throw = false)
        {
            try
            {
                action?.Invoke();
            }
            catch (Exception ex)
            {
                // Log Record
                Console.WriteLine(ex.ToString());
                if (@throw) throw;
            }
        }
    }
}
