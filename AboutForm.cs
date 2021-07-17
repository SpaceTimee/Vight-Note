using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Vight_Note
{
    public partial class AboutForm : Form
    {
        public static class Define
        {
            public const string MAINPAGE_URL = "https://www.spacetimee.xyz/";
            public const string OPENSOURCE_URL = "https://github.com/SpaceTimee/Vight-Note";
            public const string EMAIL = "Zeus6_6@163.com";
        }

        public AboutForm(bool isDarkMode)
        {
            InitializeComponent();

            //设定暗色模式
            CheckDarkMode(isDarkMode);

            //显示版本号
            VersionLabel.Text = "版本号: " + Application.ProductVersion;
        }
        private void CheckDarkMode(bool isDarkMode)
        {
            if (isDarkMode)
            {
                BackColor = Color.Black;
                ForeColor = Color.Gray;
                MainPageLinkLabel.LinkColor = Color.Red;
                MainPageLinkLabel.ActiveLinkColor = Color.Blue;
                OpenSourceLinkLabel.LinkColor = Color.Red;
                OpenSourceLinkLabel.ActiveLinkColor = Color.Blue;
                EmailLinkLabel.LinkColor = Color.Red;
                EmailLinkLabel.ActiveLinkColor = Color.Blue;
            }
        }

        private void MainPageLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Define.MAINPAGE_URL);
        }
        private void OpenSourceLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Define.OPENSOURCE_URL);
        }
        private void EmailLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:" + Define.EMAIL);
        }
    }
}
