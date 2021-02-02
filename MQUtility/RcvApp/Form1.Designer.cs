
namespace RcvApp
{
    partial class RcvForm
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
            this.rtxt_ShowMqInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtxt_ShowMqInfo
            // 
            this.rtxt_ShowMqInfo.Location = new System.Drawing.Point(28, 22);
            this.rtxt_ShowMqInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtxt_ShowMqInfo.Name = "rtxt_ShowMqInfo";
            this.rtxt_ShowMqInfo.Size = new System.Drawing.Size(745, 405);
            this.rtxt_ShowMqInfo.TabIndex = 22;
            this.rtxt_ShowMqInfo.Text = "";
            // 
            // RcvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxt_ShowMqInfo);
            this.Name = "RcvForm";
            this.Text = "RcvForm";
            this.Load += new System.EventHandler(this.RcvForm_Load);
            this.Shown += new System.EventHandler(this.RcvForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtxt_ShowMqInfo;
    }
}

