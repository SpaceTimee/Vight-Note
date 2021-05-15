using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Diagnostics;

namespace Vight_Note
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public static class Define
        {
            public const string NAME = "Vight Note";
            public const string EXENAME = "Vight Note.exe";
            public static readonly string VERSION = Application.ProductVersion;
            public const string DEVELOPER = "Space Time";
            public const string EMAIL = "Zeus6_6@163.com";
            public const string RELEASEURL = "https://spacetime.lanzous.com/b01666yti";
            public const string RELEASEPASSWORD = "3a57";
        }

        public MainForm(string[] args)
        {
            InitializeComponent();

            Welcome();  //首次欢迎界面

            CheckOpacity();
            CheckDarkMode();
            CheckLiteMode();

            if (args.Length >= 1)   //拖拽至图标打开文件
                ImportFile(args[0]);
        }

        private void CheckOpacity()
        {
            //设定Opacity的值
            this.Opacity = Convert.ToDouble(ConfigurationManager.AppSettings["Opacity"]);
        }

        private void CheckDarkMode()
        {
            //判断IsDarkMode的值(位于App.config中)
            if (ConfigurationManager.AppSettings["IsDarkMode"].ToLower() == "false")
            {
                //上次退出前未开启暗色模式
                DarkMode.Checked = false;

                TextBox.BackColor = Color.White;
                TextBox.ForeColor = Color.Black;
                TextMenu.BackColor = Color.White;
            }
            else if (ConfigurationManager.AppSettings["IsDarkMode"].ToLower() == "true")
            {
                //上次退出前开启了暗色模式
                DarkMode.Checked = true;

                TextBox.BackColor = Color.Black;
                TextBox.ForeColor = Color.Gray;
                TextMenu.BackColor = Color.Gray;
            }
        }

        private void CheckLiteMode()
        {
            //判断IsLiteMode的值(位于App.config中)
            if (ConfigurationManager.AppSettings["IsLiteMode"].ToLower() == "false")
            {
                //上次退出前未开启轻模式
                LiteMode.Checked = false;

                Create.Text = "创建窗口 (Ctrl+N)";
                //Close.Text不变
                Save.Text = "保存文件 (Ctrl+S)";
                Import.Text = "导入文件 (Ctrl+O)";
            }
            else if (ConfigurationManager.AppSettings["IsLiteMode"].ToLower() == "true")
            {
                //上次退出前开启了轻模式
                LiteMode.Checked = true;

                Create.Text = "创建窗口 (N)";
                //Close.Text不变
                Save.Text = "保存文件 (S)";
                Import.Text = "导入文件 (O)";
            }
        }

        private void Welcome()
        {
            //判断IsFirstRun的值(位于App.config中)
            if (ConfigurationManager.AppSettings["IsFirstRun"].ToLower() == "true")
            {
                //第一次运行
                MessageBox.Show
                (
$@"在我的印象里，这似乎是你第一次使用我
emmmm...
很高兴认识你，我的主人(脸红)
那个...我是{Define.NAME}
这是{Define.DEVELOPER}给我起的名字
哦，忘记告诉你了，那是我的开发者
偷偷告诉你哦
我已经有很多好用的小功能了
啊...现在是看不到的啦
它们都藏在便签界面的右键菜单里
等会儿一定要去试试啊
啊，似乎耽误你太多时间了
准备好了就点确定吧"
                );

                AboutMe();

                //将IsFirstRun置为false
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Remove("IsFirstRun");
                config.AppSettings.Settings.Add("IsFirstRun", "false");
                config.Save();
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (File.Exists(Define.EXENAME))
                Process.Start(Define.EXENAME);
            else
                MessageBox.Show("创建失败，可能是文件路径损坏导致的，重新安装可能可以解决哦");
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            #region 配置saveDialog的参数
            saveDialog.Title = "Vight Saver";
            saveDialog.RestoreDirectory = true; //自动填充用户上次选择的目录
            saveDialog.FileName = "无名文件";   //默认文件名
            saveDialog.Filter = "文本文件 (*.txt)|*.txt|Vight Text (*.vtxt)|*.vtxt";
            saveDialog.FilterIndex = 1; //默认txt
            saveDialog.AddExtension = true; //无后缀时自动增加后缀
            saveDialog.CheckFileExists = false;  //不检查文件是否正确
            saveDialog.CheckPathExists = true;  //检查路径是否正确
            saveDialog.SupportMultiDottedExtensions = true; //支持多拓展名
            saveDialog.AutoUpgradeEnabled = true;   //自动升级对话框样式
            #endregion

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveDialog.FileName.ToString();   //文件路径

                FileStream saver = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite | FileShare.Delete);
                StreamWriter writer = new StreamWriter(saver);

                writer.Write(TextBox.Text);
                writer.Flush();
                writer.Close();
                saver.Close();
            }
        }

        private void Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            #region 配置openDialog的参数
            openDialog.Title = "Vight Importer";
            openDialog.Multiselect = false; //不允许选择多个文件
            openDialog.RestoreDirectory = true; //自动填充用户上次选择的目录
            openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openDialog.Filter = "文本文件 (*.txt)|*.txt|Vight Text (*.vtxt)|*.vtxt|所有文件 (*.*)|*.*";
            openDialog.FilterIndex = 3; //默认all
            openDialog.AddExtension = true; //无后缀时自动增加后缀
            openDialog.CheckFileExists = true;  //检查文件是否正确
            openDialog.CheckPathExists = true;  //检查路径是否正确
            openDialog.ReadOnlyChecked = false; //不设定只读
            openDialog.ShowReadOnly = false;    //不向用户显示只读选项
            openDialog.SupportMultiDottedExtensions = true; //支持多拓展名
            openDialog.AutoUpgradeEnabled = true;   //自动升级对话框样式
            #endregion

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openDialog.FileName.ToString();   //文件路径
                ImportFile(filePath);
            }
        }

        private void ImproveOpacity_Click(object sender, EventArgs e)
        {
            if (this.Opacity >= 0.2)
            {
                this.Opacity -= 0.05;

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Remove("Opacity");
                config.AppSettings.Settings.Add("Opacity", Convert.ToString(this.Opacity));
                config.Save();
            }
        }

        private void ReduceOpacity_Click(object sender, EventArgs e)
        {
            this.Opacity += 0.05;

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("Opacity");
            config.AppSettings.Settings.Add("Opacity", Convert.ToString(this.Opacity));
            config.Save();
        }

        private void AlwaysTop_Click(object sender, EventArgs e)
        {
            AlwaysTop.Checked = !AlwaysTop.Checked;
            this.TopMost = !this.TopMost;
        }

        private void LockTextBox_Click(object sender, EventArgs e)
        {
            if (!LockTextBox.Checked)
            {
                //锁定
                LockTextBox.Checked = !LockTextBox.Checked;
                LockTextBox.Image = Vight_Note.Properties.Resources.Lock;
                TextBox.ReadOnly = !TextBox.ReadOnly;
            }
            else
            {
                //解锁
                LockTextBox.Checked = !LockTextBox.Checked;
                LockTextBox.Image = Vight_Note.Properties.Resources.Unlock;
                TextBox.ReadOnly = !TextBox.ReadOnly;
            }
        }

        private void DarkMode_Click(object sender, EventArgs e)
        {
            if (!DarkMode.Checked)
            {
                //开启暗色
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Remove("IsDarkMode");
                config.AppSettings.Settings.Add("IsDarkMode", "true");
                config.Save();

                DarkMode.Checked = !DarkMode.Checked;
                TextBox.BackColor = Color.Black;
                TextBox.ForeColor = Color.Gray;
                TextMenu.BackColor = Color.Gray;
            }
            else
            {
                //关闭暗色
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Remove("IsDarkMode");
                config.AppSettings.Settings.Add("IsDarkMode", "false");
                config.Save();

                DarkMode.Checked = !DarkMode.Checked;
                TextBox.BackColor = Color.White;
                TextBox.ForeColor = Color.Black;
                TextMenu.BackColor = Color.White;
            }
        }

        private void ScrollBar_Click(object sender, EventArgs e)
        {
            if (TextBox.ScrollBars == ScrollBars.None)
            {
                //显示滚动条
                ScrollBar.Text = "隐藏滚动条";
                TextBox.ScrollBars = ScrollBars.Vertical;
            }
            else
            {
                //隐藏滚动条
                ScrollBar.Text = "显示滚动条";
                TextBox.ScrollBars = ScrollBars.None;
            }
        }

        private void OpenBorder_Click(object sender, EventArgs e)
        {
            if (this.FormBorderStyle == FormBorderStyle.Sizable)
            {
                //隐藏边框
                OpenBorder.Text = "显示边框";
                this.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                //显示边框
                OpenBorder.Text = "隐藏边框";
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        private void LiteMode_Click(object sender, EventArgs e)
        {
            if (!LiteMode.Checked)
            {
                //开启轻模式
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Remove("IsLiteMode");
                config.AppSettings.Settings.Add("IsLiteMode", "true");
                config.Save();

                LiteMode.Checked = !LiteMode.Checked;
                Create.Text = "创建窗口 (N)";
                //Close.Text不变
                Save.Text = "保存文件 (S)";
                Import.Text = "导入文件 (O)";
            }
            else
            {
                //关闭轻模式
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Remove("IsLiteMode");
                config.AppSettings.Settings.Add("IsLiteMode", "false");
                config.Save();

                LiteMode.Checked = !LiteMode.Checked;
                Create.Text = "创建窗口 (Ctrl+N)";
                //Close.Text不变
                Save.Text = "保存文件 (Ctrl+S)";
                Import.Text = "导入文件 (Ctrl+O)";
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (!LiteMode.Checked)
            {
                MessageBox.Show($"即将打开光速下载页面，记住我们的密码暗号：{Define.RELEASEPASSWORD}");
            }
            else
            {
                MessageBox.Show($"密码：{Define.RELEASEPASSWORD}");
            }
            Process.Start(Define.RELEASEURL);
        }

        private void About_Click(object sender, EventArgs e)
        {
            AboutMe();
        }

        private void WhatIsLiteMode_Click(object sender, EventArgs e)
        {
            MessageBox.Show($@"在轻模式下{Define.NAME}会智能优化提示信息，增加办公效率");
        }

        private void PrivacyPolicy_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.Vight_Note_Privacy_Policy);
        }

        //拖放
        private void TextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void TextBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] path = (string[])e.Data.GetData(DataFormats.FileDrop);
                ImportFile(path[0]);
            }
        }

        //热键
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (LockTextBox.Checked)
                return;

            if (e.Control && e.KeyCode == Keys.E)
            {
                //切换右键(普通)/(功能)菜单
                TextBox.ContextMenuStrip = TextBox.ContextMenuStrip == null ? TextMenu : null;
            }
            if (e.Control && e.KeyCode == Keys.N)
            {
                //创建窗口
                Create_Click(Create, new EventArgs());
            }
            else if (e.KeyCode == Keys.Escape)
            {
                //关闭窗口
                Close_Click(Close, new EventArgs());
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                //保存文件
                Save_Click(Save, new EventArgs());
            }
            else if (e.Control && e.KeyCode == Keys.O)
            {
                //导入文件
                Import_Click(Import, new EventArgs());
            }
        }

        //项目信息
        private void AboutMe()
        {
            if (!LiteMode.Checked)
            {
                MessageBox.Show
                (
$@"欢迎使用 {Define.NAME}！

开发者：{Define.DEVELOPER}
联系邮箱：{Define.EMAIL}
版本号：{Define.VERSION}
tip：如果感觉弹窗过多建议开启轻模式"
                );
            }
            else
            {
                MessageBox.Show
                (
$@"欢迎使用 {Define.NAME}！

开发者：{Define.DEVELOPER}
联系邮箱：{Define.EMAIL}
版本号：{Define.VERSION}"
                );
            }

        }

        //写入
        private void ImportFile(string filePath)
        {
            if (LockTextBox.Checked)
                return;

            if (!System.IO.File.Exists(filePath) || !LiteMode.Checked && ((Path.GetExtension(filePath) != ".txt" && Path.GetExtension(filePath) != ".vtxt")))
            {
                //非正常后缀提示
                MessageBox.Show("请不要往我里面塞奇怪的东西...");
            }

            if (!LiteMode.Checked && TextBox.Text != "")
            {
                //便签有内容，提示用户是否覆盖
                MessageBoxButtons msgButton = MessageBoxButtons.YesNo;

                if (MessageBox.Show("呃...已经有东西了，确定要覆盖吗？", $"{Define.NAME} 的提醒", msgButton) == DialogResult.No)
                {
                    return;
                }
            }

            FileStream importer = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite | FileShare.Delete);
            StreamReader reader = new StreamReader(importer);
            TextBox.Text = reader.ReadToEnd();
        }

        //双缓冲加快启动速度
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // 用双缓冲绘制窗口的所有子控件
                return cp;
            }
        }
    }
}
