
namespace Vight_Note
{
    partial class PrivacyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PrivacyBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PrivacyBox
            // 
            this.PrivacyBox.BackColor = System.Drawing.Color.White;
            this.PrivacyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrivacyBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.PrivacyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrivacyBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PrivacyBox.ForeColor = System.Drawing.Color.Black;
            this.PrivacyBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PrivacyBox.Location = new System.Drawing.Point(0, 0);
            this.PrivacyBox.Margin = new System.Windows.Forms.Padding(0);
            this.PrivacyBox.MaxLength = 2147483647;
            this.PrivacyBox.Multiline = true;
            this.PrivacyBox.Name = "PrivacyBox";
            this.PrivacyBox.ReadOnly = true;
            this.PrivacyBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PrivacyBox.Size = new System.Drawing.Size(1174, 829);
            this.PrivacyBox.TabIndex = 0;
            this.PrivacyBox.Text = "[Error: 隐私政策加载错误]\r\n\r\n解决方案: 请访问在线文档\r\n错误反馈: Zeus6_6@163.com";
            this.PrivacyBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrivacyBox_KeyDown);
            // 
            // PrivacyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1174, 829);
            this.Controls.Add(this.PrivacyBox);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 71);
            this.Name = "PrivacyForm";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PrivacyBox;
    }
}