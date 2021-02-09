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
            _mqPool = new MQPool(SystemMQ.FunApp).AddTargetMQ(SystemMQ.RcvApp);
            //_mqPool = new MQPool(SystemMQ.FunApp, SystemMQ.RcvApp);
            _tmrSend = new System.Timers.Timer(200);
            _tmrSend.Elapsed += DisplayMQCnt;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            _tmrSend.Start();
        }

        private void DisplayMQCnt(object sender, ElapsedEventArgs e)
        {

            TryFlow(() => {
                var mqCnt = _mqPool.GetDataCont(SystemMQ.FunApp);                
                Invoke(new Action(() => {
                    MqCntLabel.Text = mqCnt.ToString();
                }));              
            });

           
        }

        private void ClearAllMQBtn_Click(object sender, EventArgs e)
        {
            TryFlow(() =>
            {
                _mqPool.ClearData(SystemMQ.FunApp);
            });
                
        }

        private void MQRemoveFirstBtn_Click(object sender, EventArgs e)
        {
            TryFlow(() =>
            {
                _mqPool.RemoveFirstData(SystemMQ.FunApp);
            });
           
        }

        private void TryDequeuBtn_Click(object sender, EventArgs e)
        {
            TryFlow(() =>
            {
                var domainMsg = _mqPool.PeekMsg<DomainMsg>(SystemMQ.FunApp);
                DequeuTxt.Text = "Source:" + domainMsg.Id + "Data:" + domainMsg.Content + "\r\n";
            });
    
        }

        private void DequeuBtn_Click(object sender, EventArgs e)
        {
            TryFlow(() =>
            {
                var domainMsg = _mqPool.ReceiveMsg<DomainMsg>(SystemMQ.FunApp);
                DequeuTxt.Text = "Source:" + domainMsg.Id + "Data:" + domainMsg.Content + "\r\n";
            });
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
