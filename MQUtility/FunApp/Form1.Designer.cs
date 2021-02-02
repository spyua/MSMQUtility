
namespace FunApp
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
            this.MQRemoveFirstBtn = new System.Windows.Forms.Button();
            this.ClearAllMQBtn = new System.Windows.Forms.Button();
            this.MqCntLabel = new System.Windows.Forms.Label();
            this.lbl_PendingMqCnt = new System.Windows.Forms.Label();
            this.DequeuTxt = new System.Windows.Forms.TextBox();
            this.TryDequeuBtn = new System.Windows.Forms.Button();
            this.DequeuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MQRemoveFirstBtn
            // 
            this.MQRemoveFirstBtn.Location = new System.Drawing.Point(186, 70);
            this.MQRemoveFirstBtn.Name = "MQRemoveFirstBtn";
            this.MQRemoveFirstBtn.Size = new System.Drawing.Size(121, 54);
            this.MQRemoveFirstBtn.TabIndex = 22;
            this.MQRemoveFirstBtn.Text = "Remove One";
            this.MQRemoveFirstBtn.UseVisualStyleBackColor = true;
            this.MQRemoveFirstBtn.Click += new System.EventHandler(this.MQRemoveFirstBtn_Click);
            // 
            // ClearAllMQBtn
            // 
            this.ClearAllMQBtn.Location = new System.Drawing.Point(44, 70);
            this.ClearAllMQBtn.Name = "ClearAllMQBtn";
            this.ClearAllMQBtn.Size = new System.Drawing.Size(121, 54);
            this.ClearAllMQBtn.TabIndex = 21;
            this.ClearAllMQBtn.Text = "Clear MQ";
            this.ClearAllMQBtn.UseVisualStyleBackColor = true;
            this.ClearAllMQBtn.Click += new System.EventHandler(this.ClearAllMQBtn_Click);
            // 
            // MqCntLabel
            // 
            this.MqCntLabel.AutoSize = true;
            this.MqCntLabel.Location = new System.Drawing.Point(750, 33);
            this.MqCntLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MqCntLabel.Name = "MqCntLabel";
            this.MqCntLabel.Size = new System.Drawing.Size(14, 15);
            this.MqCntLabel.TabIndex = 20;
            this.MqCntLabel.Text = "0";
            // 
            // lbl_PendingMqCnt
            // 
            this.lbl_PendingMqCnt.AutoSize = true;
            this.lbl_PendingMqCnt.Location = new System.Drawing.Point(642, 33);
            this.lbl_PendingMqCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PendingMqCnt.Name = "lbl_PendingMqCnt";
            this.lbl_PendingMqCnt.Size = new System.Drawing.Size(134, 19);
            this.lbl_PendingMqCnt.TabIndex = 19;
            this.lbl_PendingMqCnt.Text = "MQ Data Num：";
            // 
            // DequeuTxt
            // 
            this.DequeuTxt.Location = new System.Drawing.Point(44, 237);
            this.DequeuTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DequeuTxt.Name = "DequeuTxt";
            this.DequeuTxt.Size = new System.Drawing.Size(346, 25);
            this.DequeuTxt.TabIndex = 24;
            // 
            // TryDequeuBtn
            // 
            this.TryDequeuBtn.Location = new System.Drawing.Point(44, 158);
            this.TryDequeuBtn.Name = "TryDequeuBtn";
            this.TryDequeuBtn.Size = new System.Drawing.Size(121, 54);
            this.TryDequeuBtn.TabIndex = 25;
            this.TryDequeuBtn.Text = "TryDequeu";
            this.TryDequeuBtn.UseVisualStyleBackColor = true;
            this.TryDequeuBtn.Click += new System.EventHandler(this.TryDequeuBtn_Click);
            // 
            // DequeuBtn
            // 
            this.DequeuBtn.Location = new System.Drawing.Point(186, 158);
            this.DequeuBtn.Name = "DequeuBtn";
            this.DequeuBtn.Size = new System.Drawing.Size(121, 54);
            this.DequeuBtn.TabIndex = 26;
            this.DequeuBtn.Text = "Dequeu";
            this.DequeuBtn.UseVisualStyleBackColor = true;
            this.DequeuBtn.Click += new System.EventHandler(this.DequeuBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DequeuBtn);
            this.Controls.Add(this.TryDequeuBtn);
            this.Controls.Add(this.DequeuTxt);
            this.Controls.Add(this.MQRemoveFirstBtn);
            this.Controls.Add(this.ClearAllMQBtn);
            this.Controls.Add(this.MqCntLabel);
            this.Controls.Add(this.lbl_PendingMqCnt);
            this.Name = "Form1";
            this.Text = "FunApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MQRemoveFirstBtn;
        private System.Windows.Forms.Button ClearAllMQBtn;
        private System.Windows.Forms.Label MqCntLabel;
        private System.Windows.Forms.Label lbl_PendingMqCnt;
        private System.Windows.Forms.TextBox DequeuTxt;
        private System.Windows.Forms.Button TryDequeuBtn;
        private System.Windows.Forms.Button DequeuBtn;
    }
}

