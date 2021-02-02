
namespace SndApp
{
    partial class SndAppForm
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
            this.txt_Send = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.SpeedlySndBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Send
            // 
            this.txt_Send.Location = new System.Drawing.Point(125, 72);
            this.txt_Send.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Send.Name = "txt_Send";
            this.txt_Send.Size = new System.Drawing.Size(637, 25);
            this.txt_Send.TabIndex = 20;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(13, 68);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(100, 28);
            this.btn_Send.TabIndex = 18;
            this.btn_Send.Text = "發送";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // SpeedlySndBtn
            // 
            this.SpeedlySndBtn.Location = new System.Drawing.Point(13, 22);
            this.SpeedlySndBtn.Name = "SpeedlySndBtn";
            this.SpeedlySndBtn.Size = new System.Drawing.Size(100, 30);
            this.SpeedlySndBtn.TabIndex = 21;
            this.SpeedlySndBtn.Text = "快速發送";
            this.SpeedlySndBtn.UseVisualStyleBackColor = true;
            this.SpeedlySndBtn.Click += new System.EventHandler(this.SpeedlySndBtn_Click);
            // 
            // SndAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 132);
            this.Controls.Add(this.SpeedlySndBtn);
            this.Controls.Add(this.txt_Send);
            this.Controls.Add(this.btn_Send);
            this.Name = "SndAppForm";
            this.Text = "SndApp";
            this.Load += new System.EventHandler(this.SndAppForm_Load);
            this.Shown += new System.EventHandler(this.SndAppForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Send;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button SpeedlySndBtn;
    }
}

