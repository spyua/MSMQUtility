
namespace AppTestMQRead
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.MqCntLabel = new System.Windows.Forms.Label();
            this.lbl_PendingMqCnt = new System.Windows.Forms.Label();
            this.ClearAllMQBtn = new System.Windows.Forms.Button();
            this.MQRemoveFirstBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MqCntLabel
            // 
            this.MqCntLabel.AutoSize = true;
            this.MqCntLabel.Location = new System.Drawing.Point(732, 26);
            this.MqCntLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MqCntLabel.Name = "MqCntLabel";
            this.MqCntLabel.Size = new System.Drawing.Size(14, 15);
            this.MqCntLabel.TabIndex = 16;
            this.MqCntLabel.Text = "0";
            this.MqCntLabel.Click += new System.EventHandler(this.MqCntLabel_Click);
            // 
            // lbl_PendingMqCnt
            // 
            this.lbl_PendingMqCnt.AutoSize = true;
            this.lbl_PendingMqCnt.Location = new System.Drawing.Point(624, 26);
            this.lbl_PendingMqCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PendingMqCnt.Name = "lbl_PendingMqCnt";
            this.lbl_PendingMqCnt.Size = new System.Drawing.Size(112, 15);
            this.lbl_PendingMqCnt.TabIndex = 15;
            this.lbl_PendingMqCnt.Text = "待處理訊息數：";
            this.lbl_PendingMqCnt.Click += new System.EventHandler(this.lbl_PendingMqCnt_Click);
            // 
            // ClearAllMQBtn
            // 
            this.ClearAllMQBtn.Location = new System.Drawing.Point(26, 63);
            this.ClearAllMQBtn.Name = "ClearAllMQBtn";
            this.ClearAllMQBtn.Size = new System.Drawing.Size(121, 54);
            this.ClearAllMQBtn.TabIndex = 17;
            this.ClearAllMQBtn.Text = "清空MQ";
            this.ClearAllMQBtn.UseVisualStyleBackColor = true;
            this.ClearAllMQBtn.Click += new System.EventHandler(this.ClearAllMQBtn_Click);
            // 
            // MQRemoveFirstBtn
            // 
            this.MQRemoveFirstBtn.Location = new System.Drawing.Point(168, 63);
            this.MQRemoveFirstBtn.Name = "MQRemoveFirstBtn";
            this.MQRemoveFirstBtn.Size = new System.Drawing.Size(121, 54);
            this.MQRemoveFirstBtn.TabIndex = 18;
            this.MQRemoveFirstBtn.Text = "清掉一筆";
            this.MQRemoveFirstBtn.UseVisualStyleBackColor = true;
            this.MQRemoveFirstBtn.Click += new System.EventHandler(this.MQRemoveFirstBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MQRemoveFirstBtn);
            this.Controls.Add(this.ClearAllMQBtn);
            this.Controls.Add(this.MqCntLabel);
            this.Controls.Add(this.lbl_PendingMqCnt);
            this.Name = "Form1";
            this.Text = "TestMQRead";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MqCntLabel;
        private System.Windows.Forms.Label lbl_PendingMqCnt;
        private System.Windows.Forms.Button ClearAllMQBtn;
        private System.Windows.Forms.Button MQRemoveFirstBtn;
    }
}

