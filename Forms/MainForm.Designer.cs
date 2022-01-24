
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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.FunctionMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Create = new System.Windows.Forms.ToolStripMenuItem();
            this.Close = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Export = new System.Windows.Forms.ToolStripMenuItem();
            this.Import = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Search = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ImproveOpacity = new System.Windows.Forms.ToolStripMenuItem();
            this.ReduceOpacity = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.AlwaysTop = new System.Windows.Forms.ToolStripMenuItem();
            this.LockTextBox = new System.Windows.Forms.ToolStripMenuItem();
            this.DarkMode = new System.Windows.Forms.ToolStripMenuItem();
            this.ScrollBar = new System.Windows.Forms.ToolStripMenuItem();
            this.HideBorder = new System.Windows.Forms.ToolStripMenuItem();
            this.LiteMode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.WhatIsLiteMode = new System.Windows.Forms.ToolStripMenuItem();
            this.Update = new System.Windows.Forms.ToolStripMenuItem();
            this.PrivacyPolicy = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.TextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Count = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Run = new System.Windows.Forms.ToolStripMenuItem();
            this.Translate = new System.Windows.Forms.ToolStripMenuItem();
            this.FunctionMenu.SuspendLayout();
            this.TextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.AllowDrop = true;
            this.TextBox.BackColor = System.Drawing.Color.White;
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.ContextMenuStrip = this.FunctionMenu;
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox.ForeColor = System.Drawing.Color.Black;
            this.TextBox.HideSelection = false;
            this.TextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextBox.Location = new System.Drawing.Point(0, 0);
            this.TextBox.Margin = new System.Windows.Forms.Padding(0);
            this.TextBox.MaxLength = 2147483647;
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(404, 438);
            this.TextBox.TabIndex = 0;
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.TextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_DragDrop);
            this.TextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBox_DragEnter);
            // 
            // FunctionMenu
            // 
            this.FunctionMenu.BackColor = System.Drawing.Color.White;
            this.FunctionMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.FunctionMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FunctionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Create,
            this.Close,
            this.toolStripSeparator1,
            this.Save,
            this.Export,
            this.Import,
            this.toolStripSeparator2,
            this.Search,
            this.toolStripSeparator6,
            this.ImproveOpacity,
            this.ReduceOpacity,
            this.toolStripSeparator3,
            this.AlwaysTop,
            this.LockTextBox,
            this.DarkMode,
            this.ScrollBar,
            this.HideBorder,
            this.LiteMode,
            this.toolStripSeparator4,
            this.Settings,
            this.Help});
            this.FunctionMenu.Name = "TextMenu";
            this.FunctionMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.FunctionMenu.ShowCheckMargin = true;
            this.FunctionMenu.Size = new System.Drawing.Size(380, 718);
            this.FunctionMenu.Opening += new System.ComponentModel.CancelEventHandler(this.FunctionMenu_Opening);
            this.FunctionMenu.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FunctionMenu_PreviewKeyDown);
            // 
            // Create
            // 
            this.Create.ForeColor = System.Drawing.Color.Black;
            this.Create.Image = global::Vight_Note.Properties.Resources.Create;
            this.Create.Name = "Create";
            this.Create.ShortcutKeyDisplayString = "(Ctrl+N)";
            this.Create.Size = new System.Drawing.Size(379, 40);
            this.Create.Text = "创建窗口";
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Close
            // 
            this.Close.ForeColor = System.Drawing.Color.Black;
            this.Close.Image = global::Vight_Note.Properties.Resources.Close;
            this.Close.Name = "Close";
            this.Close.ShortcutKeyDisplayString = "(Ctrl+W)";
            this.Close.Size = new System.Drawing.Size(379, 40);
            this.Close.Text = "关闭窗口";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(376, 6);
            // 
            // Save
            // 
            this.Save.ForeColor = System.Drawing.Color.Black;
            this.Save.Image = global::Vight_Note.Properties.Resources.Save;
            this.Save.Name = "Save";
            this.Save.ShortcutKeyDisplayString = "(Ctrl+S)";
            this.Save.Size = new System.Drawing.Size(379, 40);
            this.Save.Text = "保存文件";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Export
            // 
            this.Export.ForeColor = System.Drawing.Color.Black;
            this.Export.Image = global::Vight_Note.Properties.Resources.Export;
            this.Export.Name = "Export";
            this.Export.ShortcutKeyDisplayString = "(Alt+S)";
            this.Export.Size = new System.Drawing.Size(379, 40);
            this.Export.Text = "导出文件";
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Import
            // 
            this.Import.ForeColor = System.Drawing.Color.Black;
            this.Import.Image = global::Vight_Note.Properties.Resources.Import;
            this.Import.Name = "Import";
            this.Import.ShortcutKeyDisplayString = "(Ctrl+O)";
            this.Import.Size = new System.Drawing.Size(379, 40);
            this.Import.Text = "导入文件";
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(376, 6);
            // 
            // Search
            // 
            this.Search.ForeColor = System.Drawing.Color.Black;
            this.Search.Image = global::Vight_Note.Properties.Resources.Search;
            this.Search.Name = "Search";
            this.Search.ShortcutKeyDisplayString = "(Ctrl+F)";
            this.Search.Size = new System.Drawing.Size(379, 40);
            this.Search.Text = "查找文本";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(376, 6);
            // 
            // ImproveOpacity
            // 
            this.ImproveOpacity.ForeColor = System.Drawing.Color.Black;
            this.ImproveOpacity.Image = global::Vight_Note.Properties.Resources.Improve;
            this.ImproveOpacity.Name = "ImproveOpacity";
            this.ImproveOpacity.ShortcutKeyDisplayString = "(Ctrl+Alt+U)";
            this.ImproveOpacity.Size = new System.Drawing.Size(379, 40);
            this.ImproveOpacity.Text = "透明度+";
            this.ImproveOpacity.Click += new System.EventHandler(this.ImproveOpacity_Click);
            // 
            // ReduceOpacity
            // 
            this.ReduceOpacity.ForeColor = System.Drawing.Color.Black;
            this.ReduceOpacity.Image = global::Vight_Note.Properties.Resources.Reduce;
            this.ReduceOpacity.Name = "ReduceOpacity";
            this.ReduceOpacity.ShortcutKeyDisplayString = "(Ctrl+Alt+D)";
            this.ReduceOpacity.Size = new System.Drawing.Size(379, 40);
            this.ReduceOpacity.Text = "透明度-";
            this.ReduceOpacity.Click += new System.EventHandler(this.ReduceOpacity_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(376, 6);
            // 
            // AlwaysTop
            // 
            this.AlwaysTop.ForeColor = System.Drawing.Color.Black;
            this.AlwaysTop.Image = global::Vight_Note.Properties.Resources.Top;
            this.AlwaysTop.Name = "AlwaysTop";
            this.AlwaysTop.ShortcutKeyDisplayString = "(Ctrl+Alt+T)";
            this.AlwaysTop.Size = new System.Drawing.Size(379, 40);
            this.AlwaysTop.Text = "置顶窗口";
            this.AlwaysTop.Click += new System.EventHandler(this.AlwaysTop_Click);
            // 
            // LockTextBox
            // 
            this.LockTextBox.ForeColor = System.Drawing.Color.Black;
            this.LockTextBox.Image = global::Vight_Note.Properties.Resources.Unlock;
            this.LockTextBox.Name = "LockTextBox";
            this.LockTextBox.ShortcutKeyDisplayString = "(Ctrl+Alt+L)";
            this.LockTextBox.Size = new System.Drawing.Size(379, 40);
            this.LockTextBox.Text = "锁定输入";
            this.LockTextBox.Click += new System.EventHandler(this.LockTextBox_Click);
            // 
            // DarkMode
            // 
            this.DarkMode.ForeColor = System.Drawing.Color.Black;
            this.DarkMode.Image = global::Vight_Note.Properties.Resources.Dark;
            this.DarkMode.Name = "DarkMode";
            this.DarkMode.ShortcutKeyDisplayString = "(Ctrl+Alt+B)";
            this.DarkMode.Size = new System.Drawing.Size(379, 40);
            this.DarkMode.Text = "夜间模式";
            this.DarkMode.Click += new System.EventHandler(this.DarkMode_Click);
            // 
            // ScrollBar
            // 
            this.ScrollBar.ForeColor = System.Drawing.Color.Black;
            this.ScrollBar.Image = global::Vight_Note.Properties.Resources.Scroll;
            this.ScrollBar.Name = "ScrollBar";
            this.ScrollBar.ShortcutKeyDisplayString = "(Ctrl+Alt+R)";
            this.ScrollBar.Size = new System.Drawing.Size(379, 40);
            this.ScrollBar.Text = "显示滑块";
            this.ScrollBar.Click += new System.EventHandler(this.ScrollBar_Click);
            // 
            // HideBorder
            // 
            this.HideBorder.ForeColor = System.Drawing.Color.Black;
            this.HideBorder.Image = global::Vight_Note.Properties.Resources.Border;
            this.HideBorder.Name = "HideBorder";
            this.HideBorder.ShortcutKeyDisplayString = "(Ctrl+Alt+H)";
            this.HideBorder.Size = new System.Drawing.Size(379, 40);
            this.HideBorder.Text = "隐藏边框";
            this.HideBorder.Click += new System.EventHandler(this.OpenBorder_Click);
            // 
            // LiteMode
            // 
            this.LiteMode.ForeColor = System.Drawing.Color.Black;
            this.LiteMode.Image = global::Vight_Note.Properties.Resources.Lite;
            this.LiteMode.Name = "LiteMode";
            this.LiteMode.Size = new System.Drawing.Size(379, 40);
            this.LiteMode.Text = "轻模式";
            this.LiteMode.Click += new System.EventHandler(this.LiteMode_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(376, 6);
            // 
            // Settings
            // 
            this.Settings.ForeColor = System.Drawing.Color.Black;
            this.Settings.Image = global::Vight_Note.Properties.Resources.Settings;
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(379, 40);
            this.Settings.Text = "设置";
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Help
            // 
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WhatIsLiteMode,
            this.Update,
            this.PrivacyPolicy,
            this.About});
            this.Help.ForeColor = System.Drawing.Color.Black;
            this.Help.Image = global::Vight_Note.Properties.Resources.Help;
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(379, 40);
            this.Help.Text = "帮助";
            // 
            // WhatIsLiteMode
            // 
            this.WhatIsLiteMode.ForeColor = System.Drawing.Color.Black;
            this.WhatIsLiteMode.Image = global::Vight_Note.Properties.Resources.What;
            this.WhatIsLiteMode.Name = "WhatIsLiteMode";
            this.WhatIsLiteMode.Size = new System.Drawing.Size(291, 44);
            this.WhatIsLiteMode.Text = "什么是轻模式";
            this.WhatIsLiteMode.Click += new System.EventHandler(this.WhatIsLiteMode_Click);
            // 
            // Update
            // 
            this.Update.ForeColor = System.Drawing.Color.Black;
            this.Update.Image = global::Vight_Note.Properties.Resources.Update;
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(291, 44);
            this.Update.Text = "检查更新";
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // PrivacyPolicy
            // 
            this.PrivacyPolicy.ForeColor = System.Drawing.Color.Black;
            this.PrivacyPolicy.Image = global::Vight_Note.Properties.Resources.Privacy;
            this.PrivacyPolicy.Name = "PrivacyPolicy";
            this.PrivacyPolicy.Size = new System.Drawing.Size(291, 44);
            this.PrivacyPolicy.Text = "隐私政策";
            this.PrivacyPolicy.Click += new System.EventHandler(this.PrivacyPolicy_Click);
            // 
            // About
            // 
            this.About.ForeColor = System.Drawing.Color.Black;
            this.About.Image = global::Vight_Note.Properties.Resources.About;
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(291, 44);
            this.About.Text = "关于";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // TextMenu
            // 
            this.TextMenu.BackColor = System.Drawing.Color.White;
            this.TextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.TextMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Count,
            this.toolStripSeparator5,
            this.Run,
            this.Translate});
            this.TextMenu.Name = "TextMenu";
            this.TextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TextMenu.ShowCheckMargin = true;
            this.TextMenu.Size = new System.Drawing.Size(223, 130);
            // 
            // Count
            // 
            this.Count.ForeColor = System.Drawing.Color.Black;
            this.Count.Image = global::Vight_Note.Properties.Resources.Count;
            this.Count.Name = "Count";
            this.Count.ShortcutKeyDisplayString = "";
            this.Count.Size = new System.Drawing.Size(222, 40);
            this.Count.Text = "字数统计";
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(219, 6);
            // 
            // Run
            // 
            this.Run.ForeColor = System.Drawing.Color.Black;
            this.Run.Image = global::Vight_Note.Properties.Resources.Run;
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(222, 40);
            this.Run.Text = "智能运行";
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Translate
            // 
            this.Translate.ForeColor = System.Drawing.Color.Black;
            this.Translate.Image = global::Vight_Note.Properties.Resources.Translate;
            this.Translate.Name = "Translate";
            this.Translate.Size = new System.Drawing.Size(222, 40);
            this.Translate.Text = "快捷翻译";
            this.Translate.Click += new System.EventHandler(this.Translate_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 438);
            this.Controls.Add(this.TextBox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(300, 71);
            this.Name = "MainForm";
            this.Opacity = 0.85D;
            this.ShowIcon = false;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.FunctionMenu.ResumeLayout(false);
            this.TextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip FunctionMenu;
        private new System.Windows.Forms.ToolStripMenuItem Close;
        private System.Windows.Forms.ToolStripMenuItem HideBorder;
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
        private System.Windows.Forms.ContextMenuStrip TextMenu;
        private System.Windows.Forms.ToolStripMenuItem Count;
        private System.Windows.Forms.ToolStripMenuItem Run;
        private System.Windows.Forms.ToolStripMenuItem Translate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem Search;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        internal System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.ToolStripMenuItem Settings;
    }
}

