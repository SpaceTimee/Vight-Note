
namespace Vight_Note.Forms
{
    partial class SettingsForm
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
            this.SettingsMenu = new System.Windows.Forms.MenuStrip();
            this.OpacitySetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.PagePanel = new System.Windows.Forms.Panel();
            this.SettingsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsMenu
            // 
            this.SettingsMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SettingsMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SettingsMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.SettingsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.SettingsMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.SettingsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpacitySetting,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.SettingsMenu.Location = new System.Drawing.Point(0, 0);
            this.SettingsMenu.Name = "SettingsMenu";
            this.SettingsMenu.ShowItemToolTips = true;
            this.SettingsMenu.Size = new System.Drawing.Size(93, 438);
            this.SettingsMenu.TabIndex = 0;
            // 
            // OpacitySetting
            // 
            this.OpacitySetting.AutoToolTip = true;
            this.OpacitySetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OpacitySetting.Name = "OpacitySetting";
            this.OpacitySetting.Padding = new System.Windows.Forms.Padding(0);
            this.OpacitySetting.ShowShortcutKeys = false;
            this.OpacitySetting.Size = new System.Drawing.Size(236, 35);
            this.OpacitySetting.Text = "透明度";
            this.OpacitySetting.ToolTipText = "调整窗口透明度";
            this.OpacitySetting.Click += new System.EventHandler(this.OpacitySetting_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(236, 4);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(236, 4);
            // 
            // PagePanel
            // 
            this.PagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PagePanel.Location = new System.Drawing.Point(93, 0);
            this.PagePanel.Margin = new System.Windows.Forms.Padding(0);
            this.PagePanel.Name = "PagePanel";
            this.PagePanel.Size = new System.Drawing.Size(311, 438);
            this.PagePanel.TabIndex = 0;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 438);
            this.Controls.Add(this.PagePanel);
            this.Controls.Add(this.SettingsMenu);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(92, 71);
            this.Name = "SettingsForm";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
            this.SettingsMenu.ResumeLayout(false);
            this.SettingsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip SettingsMenu;
        private System.Windows.Forms.ToolStripMenuItem OpacitySetting;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Panel PagePanel;
    }
}