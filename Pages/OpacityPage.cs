using System.Drawing;
using System.Windows.Forms;

namespace Vight_Note.Pages
{
    public partial class OpacityPage : Form
    {
        public OpacityPage(bool isDarkMode)
        {
            InitializeComponent();

            //设定暗色模式
            CheckDarkMode(isDarkMode);
        }
        private void CheckDarkMode(bool isDarkMode)
        {
            if (isDarkMode)
            {
                BackColor = Color.Black;
                ForeColor = Color.Gray;
            }
        }
    }
}
