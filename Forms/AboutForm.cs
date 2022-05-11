using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Vight_Note
{
    public partial class AboutForm : Form
    {
        private static class Define
        {
            public const string MAINPAGE_URL = "https://www.spacetimee.xyz/";
            public const string OPENSOURCE_URL = "https://github.com/SpaceTimee/Vight-Note";
            public const string EMAIL = "Zeus6_6@163.com";

            public static readonly string[] TIPS = new string[]
            {
                "你用过.vtxt文件吗?", "试试把文件拖进来吧", "锁定输入也会锁定热键", "求求别用Ctrl+Alt+E了", "亲，给个Star呗~",
                "咕咕咕", "6月31日打开会有惊喜", "你在看我吗(⁄ ⁄•⁄ω⁄•⁄ ⁄)", "Vight是姓，Note是名" ,"Error: 404 Not Found",
                "窗口太小了? 那就把它拉长​​​​‎‍‌​​​​‏‌​​​​​‏​‎​​​​‏​‏​​​​‏‎‌​​​​‌‌‍​​​​‎​‎​​​​‏‍‌​​​​‏‎‌​​​​‏​‌","❤", "I am simply a note", "关于: 关于:","•ᴗ•",
                "便签也需要休息呢","(｡･ω･｡)ﾉ♡" ,"Ciallo～(∠・ω< )⌒★","住在电脑里也很舒服呢~","便签和人类是两个物种",
                "我不吃饭,我吃电", "胡萝卜是什么味道的呢?","棒棒糖是什么味道的呢?","外面的世界是什么样的?","(๑• . •๑)",
                "更新失败就多试几次吧","主...主人?","轻模式是个好东西","?","你见过多少条关于呢?",
                "试试用Esc键关闭弹窗吧","1000001000","VmlnaHQ Tm90ZQ"
            };
        }

        public AboutForm(bool isDarkMode)
        {
            InitializeComponent();

            //设定暗色模式
            CheckDarkMode(isDarkMode);

            //显示版本号
            VersionLabel.Text = "版本号: " + Application.ProductVersion;

            //显示随机tip
            Random random = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            Text = $"关于: {Define.TIPS[random.Next(0, Define.TIPS.Length)]}";
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

        private void MainPageLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start(Define.MAINPAGE_URL);
        private void OpenSourceLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start(Define.OPENSOURCE_URL);
        private void EmailLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("mailto:" + Define.EMAIL);

        //热键
        private void AboutForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();    //关闭窗口
        }
    }
}