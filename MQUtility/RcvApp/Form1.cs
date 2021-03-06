﻿using MQUtility;
using System;
using System.Windows.Forms;
using TestDomain;

namespace RcvApp
{
    public partial class RcvForm : Form
    {
        private IMQPool _mqPool;

        public RcvForm()
        {
            InitializeComponent();
        }


        private void RcvForm_Load(object sender, EventArgs e)
        {
            _mqPool = MQPool.Instance.AddMQ(SystemMQ.RcvApp);
        }

        private void RcvForm_Shown(object sender, EventArgs e)
        {
            _mqPool.RegisterRcv(SystemMQ.RcvApp, obj =>
            {
                var msg = obj as DomainMsg;
                Invoke(new Action(() => {
                    var content = "Source:" + msg.Id + "\t Data:" + msg.Content + "\r\n";
                    rtxt_ShowMqInfo.AppendText(content);
                }));
            });
        }

    }
}
