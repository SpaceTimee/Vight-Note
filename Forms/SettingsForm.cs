using System.Drawing;
using System.Windows.Forms;
using Vight_Note.Pages;

namespace Vight_Note.Forms
{
    public partial class SettingsForm : Form
    {
        private static class Define
        {
            public static bool IS_DARK_MODE;
        }

        public SettingsForm(bool isDarkMode)
        {
            InitializeComponent();

            //设定暗色模式
            CheckDarkMode(isDarkMode);

            //记录暗色模式
            Define.IS_DARK_MODE = isDarkMode;
        }
        private void CheckDarkMode(bool isDarkMode)
        {
            if (isDarkMode)
            {
                BackColor = Color.Black;
                ForeColor = Color.Gray;
                SettingsMenu.BackColor = Color.DimGray;
                SettingsMenu.ForeColor = Color.Black;
            }
        }

        private void OpacitySetting_Click(object sender, System.EventArgs e)
        {
            OpacityPage opacityPage = new OpacityPage(Define.IS_DARK_MODE);
            opacityPage.MdiParent = this;
            opacityPage.Parent = PagePanel;
            opacityPage.Size = new Size(PagePanel.Width - 34, PagePanel.Height);
            opacityPage.Show();
        }

        //热键
        private void SettingsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();    //关闭窗口
        }
    }
}
