
namespace Vight_Note.Forms
{
    partial class SearchForm
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
            this.SearchFormTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchFormTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchFormTableLayoutPanel
            // 
            this.SearchFormTableLayoutPanel.AutoSize = true;
            this.SearchFormTableLayoutPanel.ColumnCount = 2;
            this.SearchFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SearchFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.SearchFormTableLayoutPanel.Controls.Add(this.SearchBox, 0, 0);
            this.SearchFormTableLayoutPanel.Controls.Add(this.SearchButton, 1, 0);
            this.SearchFormTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchFormTableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.SearchFormTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.SearchFormTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SearchFormTableLayoutPanel.Name = "SearchFormTableLayoutPanel";
            this.SearchFormTableLayoutPanel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.SearchFormTableLayoutPanel.RowCount = 1;
            this.SearchFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SearchFormTableLayoutPanel.Size = new System.Drawing.Size(404, 48);
            this.SearchFormTableLayoutPanel.TabIndex = 7;
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.BackColor = System.Drawing.Color.White;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchBox.ForeColor = System.Drawing.Color.Black;
            this.SearchBox.HideSelection = false;
            this.SearchBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SearchBox.Location = new System.Drawing.Point(3, 0);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(0);
            this.SearchBox.MaxLength = 2147483647;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(354, 44);
            this.SearchBox.TabIndex = 1;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchButton.BackgroundImage = global::Vight_Note.Properties.Resources.Search;
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Location = new System.Drawing.Point(357, 0);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(0);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(44, 44);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchForm
            // 
            this.AcceptButton = this.SearchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 48);
            this.Controls.Add(this.SearchFormTableLayoutPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(92, 71);
            this.Name = "SearchForm";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找文本";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchForm_KeyDown);
            this.SearchFormTableLayoutPanel.ResumeLayout(false);
            this.SearchFormTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel SearchFormTableLayoutPanel;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SearchButton;
    }
}