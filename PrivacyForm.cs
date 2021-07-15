using System.Windows.Forms;

namespace Vight_Note
{
    public partial class PrivacyForm : Form
    {
        public PrivacyForm()
        {
            InitializeComponent();

            PrivacyBox.Text = Properties.Resources.Vight_Note_Privacy_Policy;
            PrivacyBox.Select(0, 0);
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
