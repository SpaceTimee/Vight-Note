
namespace Vight_Note
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TextBox = new System.Windows.Forms.TextBox();
            this.TextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Create = new System.Windows.Forms.ToolStripMenuItem();
            this.Close = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Export = new System.Windows.Forms.ToolStripMenuItem();
            this.Import = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ImproveOpacity = new System.Windows.Forms.ToolStripMenuItem();
            this.ReduceOpacity = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.AlwaysTop = new System.Windows.Forms.ToolStripMenuItem();
            this.LockTextBox = new System.Windows.Forms.ToolStripMenuItem();
            this.DarkMode = new System.Windows.Forms.ToolStripMenuItem();
            this.ScrollBar = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenBorder = new System.Windows.Forms.ToolStripMenuItem();
            this.LiteMode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.WhatIsLiteMode = new System.Windows.Forms.ToolStripMenuItem();
            this.Update = new System.Windows.Forms.ToolStripMenuItem();
            this.PrivacyPolicy = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.TextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.AllowDrop = true;
            this.TextBox.BackColor = System.Drawing.Color.White;
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.ContextMenuStrip = this.TextMenu;
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox.ForeColor = System.Drawing.Color.Black;
            this.TextBox.Location = new System.Drawing.Point(0, 0);
            this.TextBox.Margin = new System.Windows.Forms.Padding(0);
            this.TextBox.MaxLength = 2147483647;
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(404, 438);
            this.TextBox.TabIndex = 0;
            this.TextBox.TabStop = false;
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.TextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_DragDrop);
            this.TextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBox_DragEnter);
            // 
            // TextMenu
            // 
            this.TextMenu.BackColor = System.Drawing.Color.White;
            this.TextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.TextMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Create,
            this.Close,
            this.toolStripSeparator1,
            this.Save,
            this.Export,
            this.Import,
            this.toolStripSeparator2,
            this.ImproveOpacity,
            this.ReduceOpacity,
            this.toolStripSeparator3,
            this.AlwaysTop,
            this.LockTextBox,
            this.DarkMode,
            this.ScrollBar,
            this.OpenBorder,
            this.LiteMode,
            this.toolStripSeparator4,
            this.Help});
            this.TextMenu.Name = "TextMenu";
            this.TextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TextMenu.ShowCheckMargin = true;
            this.TextMenu.Size = new System.Drawing.Size(369, 588);
            this.TextMenu.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TextMenu_PreviewKeyDown);
            // 
            // Create
            // 
            this.Create.Image = global::Vight_Note.Properties.Resources.Create;
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(368, 40);
            this.Create.Text = "创建窗口 (Ctrl+N)";
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Close
            // 
            this.Close.Image = global::Vight_Note.Properties.Resources.Close;
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(368, 40);
            this.Close.Text = "关闭窗口 (Ctrl+W)";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(365, 6);
            // 
            // Save
            // 
            this.Save.Image = global::Vight_Note.Properties.Resources.Save;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(368, 40);
            this.Save.Text = "保存文件 (Ctrl+S)";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Export
            // 
            this.Export.Image = global::Vight_Note.Properties.Resources.Export;
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(368, 40);
            this.Export.Text = "导出文件 (Alt+S)";
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Import
            // 
            this.Import.Image = global::Vight_Note.Properties.Resources.Import;
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(368, 40);
            this.Import.Text = "导入文件 (Ctrl+O)";
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(365, 6);
            // 
            // ImproveOpacity
            // 
            this.ImproveOpacity.Image = global::Vight_Note.Properties.Resources.Improve;
            this.ImproveOpacity.Name = "ImproveOpacity";
            this.ImproveOpacity.Size = new System.Drawing.Size(368, 40);
            this.ImproveOpacity.Text = "透明度+ (Ctrl+Alt+U)";
            this.ImproveOpacity.Click += new System.EventHandler(this.ImproveOpacity_Click);
            // 
            // ReduceOpacity
            // 
            this.ReduceOpacity.Image = global::Vight_Note.Properties.Resources.Reduce;
            this.ReduceOpacity.Name = "ReduceOpacity";
            this.ReduceOpacity.Size = new System.Drawing.Size(368, 40);
            this.ReduceOpacity.Text = "透明度- (Ctrl+Alt+D)";
            this.ReduceOpacity.Click += new System.EventHandler(this.ReduceOpacity_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(365, 6);
            // 
            // AlwaysTop
            // 
            this.AlwaysTop.Image = global::Vight_Note.Properties.Resources.Top;
            this.AlwaysTop.Name = "AlwaysTop";
            this.AlwaysTop.Size = new System.Drawing.Size(368, 40);
            this.AlwaysTop.Text = "置顶窗口 (Ctrl+Alt+T)";
            this.AlwaysTop.Click += new System.EventHandler(this.AlwaysTop_Click);
            // 
            // LockTextBox
            // 
            this.LockTextBox.Image = global::Vight_Note.Properties.Resources.Unlock;
            this.LockTextBox.Name = "LockTextBox";
            this.LockTextBox.Size = new System.Drawing.Size(368, 40);
            this.LockTextBox.Text = "锁定输入 (Ctrl+Alt+L)";
            this.LockTextBox.Click += new System.EventHandler(this.LockTextBox_Click);
            // 
            // DarkMode
            // 
            this.DarkMode.Image = global::Vight_Note.Properties.Resources.Dark;
            this.DarkMode.Name = "DarkMode";
            this.DarkMode.Size = new System.Drawing.Size(368, 40);
            this.DarkMode.Text = "夜间模式 (Ctrl+Alt+B)";
            this.DarkMode.Click += new System.EventHandler(this.DarkMode_Click);
            // 
            // ScrollBar
            // 
            this.ScrollBar.Image = global::Vight_Note.Properties.Resources.Scroll;
            this.ScrollBar.Name = "ScrollBar";
            this.ScrollBar.Size = new System.Drawing.Size(368, 40);
            this.ScrollBar.Text = "显示滚动条";
            this.ScrollBar.Click += new System.EventHandler(this.ScrollBar_Click);
            // 
            // OpenBorder
            // 
            this.OpenBorder.Image = global::Vight_Note.Properties.Resources.Border;
            this.OpenBorder.Name = "OpenBorder";
            this.OpenBorder.Size = new System.Drawing.Size(368, 40);
            this.OpenBorder.Text = "隐藏边框";
            this.OpenBorder.Click += new System.EventHandler(this.OpenBorder_Click);
            // 
            // LiteMode
            // 
            this.LiteMode.Image = ((System.Drawing.Image)(resources.GetObject("LiteMode.Image")));
            this.LiteMode.Name = "LiteMode";
            this.LiteMode.Size = new System.Drawing.Size(368, 40);
            this.LiteMode.Text = "轻模式";
            this.LiteMode.Click += new System.EventHandler(this.LiteMode_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(365, 6);
            // 
            // Help
            // 
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WhatIsLiteMode,
            this.Update,
            this.PrivacyPolicy,
            this.About});
            this.Help.Image = global::Vight_Note.Properties.Resources.Help;
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(368, 40);
            this.Help.Text = "帮助";
            // 
            // WhatIsLiteMode
            // 
            this.WhatIsLiteMode.Image = global::Vight_Note.Properties.Resources.What;
            this.WhatIsLiteMode.Name = "WhatIsLiteMode";
            this.WhatIsLiteMode.Size = new System.Drawing.Size(359, 44);
            this.WhatIsLiteMode.Text = "什么是轻模式";
            this.WhatIsLiteMode.Click += new System.EventHandler(this.WhatIsLiteMode_Click);
            // 
            // Update
            // 
            this.Update.Image = global::Vight_Note.Properties.Resources.Update;
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(359, 44);
            this.Update.Text = "检查更新";
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // PrivacyPolicy
            // 
            this.PrivacyPolicy.Image = global::Vight_Note.Properties.Resources.Privacy;
            this.PrivacyPolicy.Name = "PrivacyPolicy";
            this.PrivacyPolicy.Size = new System.Drawing.Size(359, 44);
            this.PrivacyPolicy.Text = "隐私政策";
            this.PrivacyPolicy.Click += new System.EventHandler(this.PrivacyPolicy_Click);
            // 
            // About
            // 
            this.About.Image = global::Vight_Note.Properties.Resources.About;
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(359, 44);
            this.About.Text = "关于";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(404, 438);
            this.Controls.Add(this.TextBox);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(300, 71);
            this.Name = "MainForm";
            this.Opacity = 0.85D;
            this.ShowIcon = false;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.TextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.ContextMenuStrip TextMenu;
        private new System.Windows.Forms.ToolStripMenuItem Close;
        private System.Windows.Forms.ToolStripMenuItem OpenBorder;
        private System.Windows.Forms.ToolStripMenuItem AlwaysTop;
        private System.Windows.Forms.ToolStripMenuItem ImproveOpacity;
        private System.Windows.Forms.ToolStripMenuItem ReduceOpacity;
        private System.Windows.Forms.ToolStripMenuItem DarkMode;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem Import;
        private System.Windows.Forms.ToolStripMenuItem Create;
        private System.Windows.Forms.ToolStripMenuItem LiteMode;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private new System.Windows.Forms.ToolStripMenuItem Update;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem LockTextBox;
        private System.Windows.Forms.ToolStripMenuItem WhatIsLiteMode;
        private System.Windows.Forms.ToolStripMenuItem ScrollBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem PrivacyPolicy;
        private System.Windows.Forms.ToolStripMenuItem Export;
    }
}

