
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
            this.FunctionMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Create = new System.Windows.Forms.ToolStripMenuItem();
            this.Close = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Export = new System.Windows.Forms.ToolStripMenuItem();
            this.Import = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Search = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ImproveOpacity = new System.Windows.Forms.ToolStripMenuItem();
            this.ReduceOpacity = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator4 = new System.Windows.Forms.ToolStripSeparator();
            this.AlwaysTop = new System.Windows.Forms.ToolStripMenuItem();
            this.LockTextBox = new System.Windows.Forms.ToolStripMenuItem();
            this.DarkMode = new System.Windows.Forms.ToolStripMenuItem();
            this.ScrollBar = new System.Windows.Forms.ToolStripMenuItem();
            this.HideBorder = new System.Windows.Forms.ToolStripMenuItem();
            this.LiteMode = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator5 = new System.Windows.Forms.ToolStripSeparator();
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
            resources.ApplyResources(this.TextBox, "TextBox");
            this.TextBox.AllowDrop = true;
            this.TextBox.BackColor = System.Drawing.Color.White;
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.ContextMenuStrip = this.FunctionMenu;
            this.TextBox.ForeColor = System.Drawing.Color.Black;
            this.TextBox.HideSelection = false;
            this.TextBox.Name = "TextBox";
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.TextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_DragDrop);
            this.TextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBox_DragEnter);
            // 
            // FunctionMenu
            // 
            resources.ApplyResources(this.FunctionMenu, "FunctionMenu");
            this.FunctionMenu.BackColor = System.Drawing.Color.White;
            this.FunctionMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.FunctionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Create,
            this.Close,
            this.Separator1,
            this.Save,
            this.Export,
            this.Import,
            this.Separator2,
            this.Search,
            this.Separator3,
            this.ImproveOpacity,
            this.ReduceOpacity,
            this.Separator4,
            this.AlwaysTop,
            this.LockTextBox,
            this.ScrollBar,
            this.HideBorder,
            this.DarkMode,
            this.LiteMode,
            this.Separator5,
            this.Help});
            this.FunctionMenu.Name = "TextMenu";
            this.FunctionMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.FunctionMenu.ShowCheckMargin = true;
            this.FunctionMenu.Opening += new System.ComponentModel.CancelEventHandler(this.FunctionMenu_Opening);
            this.FunctionMenu.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FunctionMenu_PreviewKeyDown);
            // 
            // Create
            // 
            resources.ApplyResources(this.Create, "Create");
            this.Create.ForeColor = System.Drawing.Color.Black;
            this.Create.Image = global::Vight_Note.Properties.Resources.Create;
            this.Create.Name = "Create";
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Close
            // 
            resources.ApplyResources(this.Close, "Close");
            this.Close.ForeColor = System.Drawing.Color.Black;
            this.Close.Image = global::Vight_Note.Properties.Resources.Close;
            this.Close.Name = "Close";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Separator1
            // 
            resources.ApplyResources(this.Separator1, "Separator1");
            this.Separator1.ForeColor = System.Drawing.Color.Black;
            this.Separator1.Name = "Separator1";
            // 
            // Save
            // 
            resources.ApplyResources(this.Save, "Save");
            this.Save.ForeColor = System.Drawing.Color.Black;
            this.Save.Image = global::Vight_Note.Properties.Resources.Save;
            this.Save.Name = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Export
            // 
            resources.ApplyResources(this.Export, "Export");
            this.Export.ForeColor = System.Drawing.Color.Black;
            this.Export.Image = global::Vight_Note.Properties.Resources.Export;
            this.Export.Name = "Export";
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Import
            // 
            resources.ApplyResources(this.Import, "Import");
            this.Import.ForeColor = System.Drawing.Color.Black;
            this.Import.Image = global::Vight_Note.Properties.Resources.Import;
            this.Import.Name = "Import";
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Separator2
            // 
            resources.ApplyResources(this.Separator2, "Separator2");
            this.Separator2.ForeColor = System.Drawing.Color.Black;
            this.Separator2.Name = "Separator2";
            // 
            // Search
            // 
            resources.ApplyResources(this.Search, "Search");
            this.Search.ForeColor = System.Drawing.Color.Black;
            this.Search.Image = global::Vight_Note.Properties.Resources.Search;
            this.Search.Name = "Search";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Separator3
            // 
            resources.ApplyResources(this.Separator3, "Separator3");
            this.Separator3.Name = "Separator3";
            // 
            // ImproveOpacity
            // 
            resources.ApplyResources(this.ImproveOpacity, "ImproveOpacity");
            this.ImproveOpacity.ForeColor = System.Drawing.Color.Black;
            this.ImproveOpacity.Image = global::Vight_Note.Properties.Resources.Improve;
            this.ImproveOpacity.Name = "ImproveOpacity";
            this.ImproveOpacity.Click += new System.EventHandler(this.ImproveOpacity_Click);
            // 
            // ReduceOpacity
            // 
            resources.ApplyResources(this.ReduceOpacity, "ReduceOpacity");
            this.ReduceOpacity.ForeColor = System.Drawing.Color.Black;
            this.ReduceOpacity.Image = global::Vight_Note.Properties.Resources.Reduce;
            this.ReduceOpacity.Name = "ReduceOpacity";
            this.ReduceOpacity.Click += new System.EventHandler(this.ReduceOpacity_Click);
            // 
            // Separator4
            // 
            resources.ApplyResources(this.Separator4, "Separator4");
            this.Separator4.ForeColor = System.Drawing.Color.Black;
            this.Separator4.Name = "Separator4";
            // 
            // AlwaysTop
            // 
            resources.ApplyResources(this.AlwaysTop, "AlwaysTop");
            this.AlwaysTop.ForeColor = System.Drawing.Color.Black;
            this.AlwaysTop.Image = global::Vight_Note.Properties.Resources.Top;
            this.AlwaysTop.Name = "AlwaysTop";
            this.AlwaysTop.Click += new System.EventHandler(this.AlwaysTop_Click);
            // 
            // LockTextBox
            // 
            resources.ApplyResources(this.LockTextBox, "LockTextBox");
            this.LockTextBox.ForeColor = System.Drawing.Color.Black;
            this.LockTextBox.Image = global::Vight_Note.Properties.Resources.Unlock;
            this.LockTextBox.Name = "LockTextBox";
            this.LockTextBox.Click += new System.EventHandler(this.LockTextBox_Click);
            // 
            // DarkMode
            // 
            resources.ApplyResources(this.DarkMode, "DarkMode");
            this.DarkMode.ForeColor = System.Drawing.Color.Black;
            this.DarkMode.Image = global::Vight_Note.Properties.Resources.Dark;
            this.DarkMode.Name = "DarkMode";
            this.DarkMode.Click += new System.EventHandler(this.DarkMode_Click);
            // 
            // ScrollBar
            // 
            resources.ApplyResources(this.ScrollBar, "ScrollBar");
            this.ScrollBar.ForeColor = System.Drawing.Color.Black;
            this.ScrollBar.Image = global::Vight_Note.Properties.Resources.Scroll;
            this.ScrollBar.Name = "ScrollBar";
            this.ScrollBar.Click += new System.EventHandler(this.ScrollBar_Click);
            // 
            // HideBorder
            // 
            resources.ApplyResources(this.HideBorder, "HideBorder");
            this.HideBorder.ForeColor = System.Drawing.Color.Black;
            this.HideBorder.Image = global::Vight_Note.Properties.Resources.Border;
            this.HideBorder.Name = "HideBorder";
            this.HideBorder.Click += new System.EventHandler(this.OpenBorder_Click);
            // 
            // LiteMode
            // 
            resources.ApplyResources(this.LiteMode, "LiteMode");
            this.LiteMode.ForeColor = System.Drawing.Color.Black;
            this.LiteMode.Image = global::Vight_Note.Properties.Resources.Lite;
            this.LiteMode.Name = "LiteMode";
            this.LiteMode.Click += new System.EventHandler(this.LiteMode_Click);
            // 
            // Separator5
            // 
            resources.ApplyResources(this.Separator5, "Separator5");
            this.Separator5.ForeColor = System.Drawing.Color.Black;
            this.Separator5.Name = "Separator5";
            // 
            // Help
            // 
            resources.ApplyResources(this.Help, "Help");
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WhatIsLiteMode,
            this.Update,
            this.PrivacyPolicy,
            this.About});
            this.Help.ForeColor = System.Drawing.Color.Black;
            this.Help.Image = global::Vight_Note.Properties.Resources.Help;
            this.Help.Name = "Help";
            // 
            // WhatIsLiteMode
            // 
            resources.ApplyResources(this.WhatIsLiteMode, "WhatIsLiteMode");
            this.WhatIsLiteMode.ForeColor = System.Drawing.Color.Black;
            this.WhatIsLiteMode.Image = global::Vight_Note.Properties.Resources.What;
            this.WhatIsLiteMode.Name = "WhatIsLiteMode";
            this.WhatIsLiteMode.Click += new System.EventHandler(this.WhatIsLiteMode_Click);
            // 
            // Update
            // 
            resources.ApplyResources(this.Update, "Update");
            this.Update.ForeColor = System.Drawing.Color.Black;
            this.Update.Image = global::Vight_Note.Properties.Resources.Update;
            this.Update.Name = "Update";
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // PrivacyPolicy
            // 
            resources.ApplyResources(this.PrivacyPolicy, "PrivacyPolicy");
            this.PrivacyPolicy.ForeColor = System.Drawing.Color.Black;
            this.PrivacyPolicy.Image = global::Vight_Note.Properties.Resources.Privacy;
            this.PrivacyPolicy.Name = "PrivacyPolicy";
            this.PrivacyPolicy.Click += new System.EventHandler(this.PrivacyPolicy_Click);
            // 
            // About
            // 
            resources.ApplyResources(this.About, "About");
            this.About.ForeColor = System.Drawing.Color.Black;
            this.About.Image = global::Vight_Note.Properties.Resources.About;
            this.About.Name = "About";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // TextMenu
            // 
            resources.ApplyResources(this.TextMenu, "TextMenu");
            this.TextMenu.BackColor = System.Drawing.Color.White;
            this.TextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.TextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Count,
            this.toolStripSeparator5,
            this.Run,
            this.Translate});
            this.TextMenu.Name = "TextMenu";
            this.TextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TextMenu.ShowCheckMargin = true;
            // 
            // Count
            // 
            resources.ApplyResources(this.Count, "Count");
            this.Count.ForeColor = System.Drawing.Color.Black;
            this.Count.Image = global::Vight_Note.Properties.Resources.Count;
            this.Count.Name = "Count";
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // toolStripSeparator5
            // 
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            // 
            // Run
            // 
            resources.ApplyResources(this.Run, "Run");
            this.Run.ForeColor = System.Drawing.Color.Black;
            this.Run.Image = global::Vight_Note.Properties.Resources.Run;
            this.Run.Name = "Run";
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Translate
            // 
            resources.ApplyResources(this.Translate, "Translate");
            this.Translate.ForeColor = System.Drawing.Color.Black;
            this.Translate.Image = global::Vight_Note.Properties.Resources.Translate;
            this.Translate.Name = "Translate";
            this.Translate.Click += new System.EventHandler(this.Translate_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TextBox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.KeyPreview = true;
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
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.ToolStripSeparator Separator2;
        private System.Windows.Forms.ToolStripSeparator Separator4;
        private System.Windows.Forms.ToolStripSeparator Separator5;
        private System.Windows.Forms.ToolStripMenuItem PrivacyPolicy;
        private System.Windows.Forms.ToolStripMenuItem Export;
        private System.Windows.Forms.ContextMenuStrip TextMenu;
        private System.Windows.Forms.ToolStripMenuItem Count;
        private System.Windows.Forms.ToolStripMenuItem Run;
        private System.Windows.Forms.ToolStripMenuItem Translate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem Search;
        private System.Windows.Forms.ToolStripSeparator Separator3;
        internal System.Windows.Forms.TextBox TextBox;
    }
}

