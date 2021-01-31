
namespace AppNo2
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
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_ShowPendingMqCnt = new System.Windows.Forms.Label();
            this.lbl_PendingMqCnt = new System.Windows.Forms.Label();
            this.txt_Send = new System.Windows.Forms.TextBox();
            this.rtxt_ShowMqInfo = new System.Windows.Forms.RichTextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(13, 42);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(112, 34);
            this.btn_Clear.TabIndex = 11;
            this.btn_Clear.Text = "清除";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // lbl_ShowPendingMqCnt
            // 
            this.lbl_ShowPendingMqCnt.AutoSize = true;
            this.lbl_ShowPendingMqCnt.Location = new System.Drawing.Point(155, 20);
            this.lbl_ShowPendingMqCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ShowPendingMqCnt.Name = "lbl_ShowPendingMqCnt";
            this.lbl_ShowPendingMqCnt.Size = new System.Drawing.Size(32, 18);
            this.lbl_ShowPendingMqCnt.TabIndex = 10;
            this.lbl_ShowPendingMqCnt.Text = "Cnt";
            // 
            // lbl_PendingMqCnt
            // 
            this.lbl_PendingMqCnt.AutoSize = true;
            this.lbl_PendingMqCnt.Location = new System.Drawing.Point(13, 20);
            this.lbl_PendingMqCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PendingMqCnt.Name = "lbl_PendingMqCnt";
            this.lbl_PendingMqCnt.Size = new System.Drawing.Size(134, 18);
            this.lbl_PendingMqCnt.TabIndex = 9;
            this.lbl_PendingMqCnt.Text = "待處理訊息數：";
            // 
            // txt_Send
            // 
            this.txt_Send.Location = new System.Drawing.Point(256, 42);
            this.txt_Send.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Send.Name = "txt_Send";
            this.txt_Send.Size = new System.Drawing.Size(595, 29);
            this.txt_Send.TabIndex = 8;
            // 
            // rtxt_ShowMqInfo
            // 
            this.rtxt_ShowMqInfo.Location = new System.Drawing.Point(13, 86);
            this.rtxt_ShowMqInfo.Margin = new System.Windows.Forms.Padding(4);
            this.rtxt_ShowMqInfo.Name = "rtxt_ShowMqInfo";
            this.rtxt_ShowMqInfo.Size = new System.Drawing.Size(838, 442);
            this.rtxt_ShowMqInfo.TabIndex = 7;
            this.rtxt_ShowMqInfo.Text = "";
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(135, 42);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(112, 34);
            this.btn_Send.TabIndex = 6;
            this.btn_Send.Text = "發送";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 548);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.lbl_ShowPendingMqCnt);
            this.Controls.Add(this.lbl_PendingMqCnt);
            this.Controls.Add(this.txt_Send);
            this.Controls.Add(this.rtxt_ShowMqInfo);
            this.Controls.Add(this.btn_Send);
            this.Name = "Form1";
            this.Text = "AppNo2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_ShowPendingMqCnt;
        private System.Windows.Forms.Label lbl_PendingMqCnt;
        private System.Windows.Forms.TextBox txt_Send;
        private System.Windows.Forms.RichTextBox rtxt_ShowMqInfo;
        private System.Windows.Forms.Button btn_Send;
    }
}

