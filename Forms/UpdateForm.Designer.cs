
namespace Vight_Note
{
    partial class UpdateForm
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
            this.TipLabel = new System.Windows.Forms.Label();
            this.LocalVersionLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.LatestVersionLabel = new System.Windows.Forms.Label();
            this.GithubButton = new System.Windows.Forms.Button();
            this.LanzouButton = new System.Windows.Forms.Button();
            this.LatestVersionTipLabel = new System.Windows.Forms.Label();
            this.LocalVersionTipLabel = new System.Windows.Forms.Label();
            this.EraseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TipLabel
            // 
            this.TipLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TipLabel.AutoSize = true;
            this.TipLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TipLabel.Location = new System.Drawing.Point(31, 369);
            this.TipLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TipLabel.Name = "TipLabel";
            this.TipLabel.Size = new System.Drawing.Size(350, 31);
            this.TipLabel.TabIndex = 0;
            this.TipLabel.Text = "点击检查更新可获取最新版本号";
            // 
            // LocalVersionLabel
            // 
            this.LocalVersionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LocalVersionLabel.AutoSize = true;
            this.LocalVersionLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocalVersionLabel.Location = new System.Drawing.Point(140, 35);
            this.LocalVersionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.LocalVersionLabel.Name = "LocalVersionLabel";
            this.LocalVersionLabel.Size = new System.Drawing.Size(62, 31);
            this.LocalVersionLabel.TabIndex = 0;
            this.LocalVersionLabel.Text = "?.?.?";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UpdateButton.Location = new System.Drawing.Point(31, 179);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(0);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(160, 54);
            this.UpdateButton.TabIndex = 1;
            this.UpdateButton.Text = "检查更新";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // LatestVersionLabel
            // 
            this.LatestVersionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LatestVersionLabel.AutoSize = true;
            this.LatestVersionLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LatestVersionLabel.Location = new System.Drawing.Point(140, 107);
            this.LatestVersionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.LatestVersionLabel.Name = "LatestVersionLabel";
            this.LatestVersionLabel.Size = new System.Drawing.Size(102, 31);
            this.LatestVersionLabel.TabIndex = 0;
            this.LatestVersionLabel.Text = "[未获取]";
            // 
            // GithubButton
            // 
            this.GithubButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GithubButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GithubButton.Location = new System.Drawing.Point(31, 274);
            this.GithubButton.Margin = new System.Windows.Forms.Padding(0);
            this.GithubButton.Name = "GithubButton";
            this.GithubButton.Size = new System.Drawing.Size(160, 54);
            this.GithubButton.TabIndex = 3;
            this.GithubButton.Text = "Github|自动";
            this.GithubButton.UseVisualStyleBackColor = true;
            this.GithubButton.Click += new System.EventHandler(this.GithubButton_Click);
            // 
            // LanzouButton
            // 
            this.LanzouButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LanzouButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LanzouButton.Location = new System.Drawing.Point(215, 274);
            this.LanzouButton.Margin = new System.Windows.Forms.Padding(0);
            this.LanzouButton.Name = "LanzouButton";
            this.LanzouButton.Size = new System.Drawing.Size(160, 54);
            this.LanzouButton.TabIndex = 4;
            this.LanzouButton.Text = "蓝奏云|手动";
            this.LanzouButton.UseVisualStyleBackColor = true;
            this.LanzouButton.Click += new System.EventHandler(this.LanzouButton_Click);
            // 
            // LatestVersionTipLabel
            // 
            this.LatestVersionTipLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LatestVersionTipLabel.AutoSize = true;
            this.LatestVersionTipLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LatestVersionTipLabel.Location = new System.Drawing.Point(31, 107);
            this.LatestVersionTipLabel.Margin = new System.Windows.Forms.Padding(0);
            this.LatestVersionTipLabel.Name = "LatestVersionTipLabel";
            this.LatestVersionTipLabel.Size = new System.Drawing.Size(116, 31);
            this.LatestVersionTipLabel.TabIndex = 0;
            this.LatestVersionTipLabel.Text = "最新版本:";
            // 
            // LocalVersionTipLabel
            // 
            this.LocalVersionTipLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LocalVersionTipLabel.AutoSize = true;
            this.LocalVersionTipLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocalVersionTipLabel.Location = new System.Drawing.Point(31, 35);
            this.LocalVersionTipLabel.Margin = new System.Windows.Forms.Padding(0);
            this.LocalVersionTipLabel.Name = "LocalVersionTipLabel";
            this.LocalVersionTipLabel.Size = new System.Drawing.Size(116, 31);
            this.LocalVersionTipLabel.TabIndex = 0;
            this.LocalVersionTipLabel.Text = "本地版本:";
            // 
            // EraseButton
            // 
            this.EraseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EraseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EraseButton.Location = new System.Drawing.Point(215, 179);
            this.EraseButton.Margin = new System.Windows.Forms.Padding(0);
            this.EraseButton.Name = "EraseButton";
            this.EraseButton.Size = new System.Drawing.Size(160, 54);
            this.EraseButton.TabIndex = 2;
            this.EraseButton.Text = "清理残余";
            this.EraseButton.UseVisualStyleBackColor = true;
            this.EraseButton.Click += new System.EventHandler(this.EraseButton_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 438);
            this.Controls.Add(this.EraseButton);
            this.Controls.Add(this.LocalVersionTipLabel);
            this.Controls.Add(this.LatestVersionTipLabel);
            this.Controls.Add(this.LanzouButton);
            this.Controls.Add(this.GithubButton);
            this.Controls.Add(this.LatestVersionLabel);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.LocalVersionLabel);
            this.Controls.Add(this.TipLabel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(92, 71);
            this.Name = "UpdateForm";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "检查更新";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UpdateForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label TipLabel;
        public System.Windows.Forms.Label LocalVersionLabel;
        private System.Windows.Forms.Button UpdateButton;
        public System.Windows.Forms.Label LatestVersionLabel;
        private System.Windows.Forms.Button GithubButton;
        private System.Windows.Forms.Button LanzouButton;
        public System.Windows.Forms.Label LatestVersionTipLabel;
        public System.Windows.Forms.Label LocalVersionTipLabel;
        private System.Windows.Forms.Button EraseButton;
    }
}