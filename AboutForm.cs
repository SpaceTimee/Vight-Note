using System.Diagnostics;
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

        public AboutForm()
        {
            InitializeComponent();

            //显示版本号
            VersionLabel.Text = "版本号: " + Application.ProductVersion;
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
