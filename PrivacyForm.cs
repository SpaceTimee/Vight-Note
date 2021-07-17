using System.Drawing;
using System.Windows.Forms;

namespace Vight_Note
{
    public partial class PrivacyForm : Form
    {
        public PrivacyForm(bool isDarkMode)
        {
            InitializeComponent();

            //设定暗色模式
            CheckDarkMode(isDarkMode);

            //显示隐私政策内容
            PrivacyBox.Text = Properties.Resources.Vight_Note_Privacy_Policy;
            PrivacyBox.Select(0, 0);
        }
        private void CheckDarkMode(bool isDarkMode)
        {
            if (isDarkMode)
            {
                PrivacyBox.BackColor = Color.Black;
                PrivacyBox.ForeColor = Color.Gray;
            }
        }

        //热键
        private void PrivacyBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                //关闭窗口
                Close();
            }
        }
    }
}
