using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vight_Note.Forms;

namespace Vight_Note
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private static class Define
        {
            public const string NAME = @"Vight Note";
            public static readonly string VERSION = Application.ProductVersion;
            public const string DEVELOPER = @"Space Time";

            public const string POLICY_URL = @"https://thoughts.teambition.com/share/609fd36543b2b70046b09b06";
            public const string THOUGHT_PING_URL = @"thoughts.teambition.com";

            #region URL的正则表达式 (URL_REGEX)
            public const string URL_REGEX = //@"^(((ht|f)tp(s?))\://)?" +
                                            @"^([a-zA-Z].)[a-zA-Z0-9\-\.]+\.(" +
                                            @"com|edu|gov|mil|net|org|biz|info|name|museum|us|ca|uk|cc|int|arpa|asia|pro|coop|aero|tv|top|xin|xyz|vip|cn|mobi|ru|de|pl|eu|io|jp|club|au|post|me|guru|expert|tw|mo|hk|fr|ar|pk|mv|in|it|ws|sh|my|cd|ac|li|co|cm|win|red|rec|travel|wang|ch|dj|er|ee|es|is|kr|mm|mn|no|ne|to|tr|za|ml|ga|xxx|porn|adult|cyou|buzz|monster|icu|shop|best|site|live|online|pw|cloud|website|life|store|fun|app|today|uno|space|world|one|link|work|email|nl|trade|bid|stream|men|art|party|date|dev|tech|church|rocks|digital|download|moe|agency|network|click|fail|news|cool|vegas|blog|review|company|la|design|services|golf|exposed|team|ltd|help|zone|loan|wtf|media|solutions|games|directory|center|care|fyi|group|ooo|science|systems|works|city|pet|run|tips|studio|guide|cash|at|support|ninja|plus|rip|marketing|vin|reisen|tools|finance|immo|wiki|viajes|global|mx|promo|recipes|photos|academy|dog|pink|money|chat|casa|cafe|ink|foundation|faith|webcam|house|technology|photography|video|blue|farm|codes|realty|tel|land|show|business|international|social|sbs|skin|page|london|health|hiv|bond|vote|autos|rest|limo|hospital|gay|bar|game|fans|ph|study|cooking|glass|place|rent|shoes|tires|wedding|cab|camp|beer|menu|movie|fish|sexy|gifts|part|mom|green|moda|baby|navy|loans|engineering|computer|camera|barga|film|kitchen|supply|pics|haus|university|fit|cheap|vet|black|law|lol|tax|bio|sale|earth|kim|love|software|fitness|llc|school|pub|deals|style|domains|band|host|direct|shopping|tube|ist|mba|photo|energy|training|taxi|gift|wine|town|bike|toys|ski|poker|yoga|parts|solar|engineer|garden|observer|sucks|hosting|bingo|christmas|gives|horse|insure|diet|fishing|whoswho|tickets|boats|flowers|storage|cfd|inc|quest|luxe|security" +
                                            @")(\:[0-9]+)*(/($|[a-zA-Z0-9\.\,\;\?\'\\\+&amp;%\$#\=~_\-]+))*$";
            #endregion URL的正则表达式 (URL_REGEX)

            public const string BAIDU_SEARCH_API = @"https://www.baidu.com/s?wd=";
            public const string BAIDU_TRANSLATE_API = @"https://fanyi.baidu.com/#zh/en/";

            public const string EMAIL_REGEX = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        }

        internal static ProcessStartInfo processStartInfo = new() { UseShellExecute = true };
        private static bool CHANGE_MARK = false;
        private static string FILE_PATH = @"";

        public MainForm(string[] args)
        {
            InitializeComponent();

            //欢迎界面和界面初始化
            MainFormInit();

            //拖拽至图标打开文件
            if (args.Length >= 1)
            {
                FILE_PATH = args[0];
                ImportFile();
            }
        }
        private void MainFormInit()
        {
            //判断IsFirstRun的值
            if (Properties.Settings.Default.IsFirstRun)
            {
                //是第一次运行
                Welcome();
            }
            else
            {
                //不是第一次运行
                CheckDarkMode();
                CheckOpacity();
                CheckLiteMode();
            }
        }
        private static void Welcome()
        {
            //显示欢迎界面
            MessageBox.Show
            (
$@"在我的印象里，这似乎是我第一次见到你
很高兴认识你，我的主人(脸红)
那个...我是{Define.NAME}
这是{Define.DEVELOPER}给我起的名字
哦，忘记告诉你了，那是我的开发者
偷偷告诉你哦
我已经有很多好用的小功能了
啊...现在是看不到的啦
它们都藏在便签的右键菜单里
等会儿一定要去试试啊
啊，似乎耽误你太多时间了
准备好了就点确定吧"
            );

            //将IsFirstRun置为false
            Properties.Settings.Default.IsFirstRun = false;
            Properties.Settings.Default.Save();
        }
        private void CheckDarkMode()
        {
            if (Properties.Settings.Default.IsDarkMode)
            {
                DarkMode.Checked = true;

                TextBox.BackColor = Color.Black;
                TextBox.ForeColor = Color.Gray;
                FunctionMenu.BackColor = Color.Gray;
            }
        }
        private void CheckOpacity()
        {
            //设定Opacity的值
            Opacity = Properties.Settings.Default.Opacity;
            Properties.Settings.Default.Save();
        }
        private void CheckLiteMode()
        {
            if (Properties.Settings.Default.IsLiteMode)
            {
                LiteMode.Checked = true;
                LiteShortcut(true);
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.ExecutablePath))
            {
                processStartInfo.FileName = Application.ExecutablePath;
                Process.Start(processStartInfo);
            }
            else
                MessageBox.Show("创建失败，可能是文件路径损坏导致的，重新安装可能可以解决哦");
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void Save_Click(object sender, EventArgs e)
        {
            //显示文件保存窗口，向用户获取保存路径
            if (sender == Export || FILE_PATH == "")
            {
                SaveFileDialog saveDialog = new();

                #region 配置saveDialog的参数
                saveDialog.Title = "Vight Saver";
                saveDialog.RestoreDirectory = true; //自动填充用户上次选择的目录
                saveDialog.FileName = "无题";   //默认文件名
                saveDialog.Filter = "文本文件 (*.txt)|*.txt|Vight Text (*.vtxt)|*.vtxt";
                saveDialog.FilterIndex = 1; //默认txt
                saveDialog.AddExtension = true; //无后缀时自动增加后缀
                saveDialog.CheckFileExists = false;  //不检查文件是否正确
                saveDialog.CheckPathExists = true;  //检查路径是否正确
                saveDialog.SupportMultiDottedExtensions = true; //支持多拓展名
                saveDialog.AutoUpgradeEnabled = true;   //自动升级对话框样式
                #endregion 配置saveDialog的参数

                if (saveDialog.ShowDialog() != DialogResult.OK)
                    return;
                else
                    FILE_PATH = saveDialog.FileName.ToString();   //文件路径
            }

            //写文件
            FileStream saver = new(FILE_PATH, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite | FileShare.Delete);
            StreamWriter writer = new(saver);
            writer.Write(TextBox.Text);
            writer.Flush();
            writer.Close();
            saver.Close();

            Text = Path.GetFileName(FILE_PATH);
            CHANGE_MARK = false;
        }
        private void Export_Click(object sender, EventArgs e)
        {
            Save_Click(Export, new EventArgs());
        }
        private void Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new();

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
            #endregion 配置openDialog的参数

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                FILE_PATH = openDialog.FileName.ToString();   //文件路径
                ImportFile();
            }
        }
        private void Search_Click(object sender, EventArgs e)
        {
            SearchForm seachForm = new(this, DarkMode.Checked);
            seachForm.ShowDialog();
        }
        private void ImproveOpacity_Click(object sender, EventArgs e)
        {
            if (Opacity >= 0.2)
            {
                Opacity -= 0.05;

                Properties.Settings.Default.Opacity = Opacity;
                Properties.Settings.Default.Save();
            }
        }
        private void ReduceOpacity_Click(object sender, EventArgs e)
        {
            Opacity += 0.05;

            Properties.Settings.Default.Opacity = Opacity;
            Properties.Settings.Default.Save();
        }
        private void AlwaysTop_Click(object sender, EventArgs e)
        {
            AlwaysTop.Checked = !AlwaysTop.Checked;
            TopMost = !TopMost;
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
                Properties.Settings.Default.IsDarkMode = true;
                Properties.Settings.Default.Save();

                DarkMode.Checked = !DarkMode.Checked;
                TextBox.BackColor = Color.Black;
                TextBox.ForeColor = Color.Gray;
                FunctionMenu.BackColor = Color.Gray;
            }
            else
            {
                //关闭暗色
                Properties.Settings.Default.IsDarkMode = false;
                Properties.Settings.Default.Save();

                DarkMode.Checked = !DarkMode.Checked;
                TextBox.BackColor = Color.White;
                TextBox.ForeColor = Color.Black;
                FunctionMenu.BackColor = Color.White;
            }
        }
        private void ScrollBar_Click(object sender, EventArgs e)
        {
            if (TextBox.ScrollBars == ScrollBars.None)
            {
                //显示滚动条
                if (System.Threading.Thread.CurrentThread.CurrentUICulture.Name != "en-US")
                    ScrollBar.Text = "隐藏滑块";
                else
                    ScrollBar.Text = "HideScroller";

                TextBox.ScrollBars = ScrollBars.Vertical;
            }
            else
            {
                //隐藏滚动条
                if (System.Threading.Thread.CurrentThread.CurrentUICulture.Name != "en-US")
                    ScrollBar.Text = "显示滑块";
                else
                    ScrollBar.Text = "ShowScroller";

                TextBox.ScrollBars = ScrollBars.None;
            }
        }
        private void OpenBorder_Click(object sender, EventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.Sizable)
            {
                //隐藏边框
                if (System.Threading.Thread.CurrentThread.CurrentUICulture.Name != "en-US")
                    HideBorder.Text = "显示边框";
                else
                    HideBorder.Text = "ShowBorder";

                FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                //显示边框
                if (System.Threading.Thread.CurrentThread.CurrentUICulture.Name != "en-US")
                    HideBorder.Text = "隐藏边框";
                else
                    HideBorder.Text = "HideBorder";

                FormBorderStyle = FormBorderStyle.Sizable;
            }
        }
        private void LiteMode_Click(object sender, EventArgs e)
        {
            if (!LiteMode.Checked)
            {
                //开启轻模式
                Properties.Settings.Default.IsLiteMode = true;
                Properties.Settings.Default.Save();

                LiteMode.Checked = !LiteMode.Checked;
                LiteShortcut(true);
            }
            else
            {
                //关闭轻模式
                Properties.Settings.Default.IsLiteMode = false;
                Properties.Settings.Default.Save();

                LiteMode.Checked = !LiteMode.Checked;
                LiteShortcut(false);
            }
        }
        private void Settings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new(DarkMode.Checked);
            settingsForm.ShowDialog();
        }
        private void Update_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new(DarkMode.Checked, LiteMode.Checked);
            updateForm.ShowDialog();
        }
        private void About_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new(DarkMode.Checked);
            aboutForm.ShowDialog();
        }
        private void WhatIsLiteMode_Click(object sender, EventArgs e)
        {
            MessageBox.Show($@"在轻模式下{Define.NAME}会智能优化提示信息，提升办公效率，建议开启");
        }
        private async void PrivacyPolicy_Click(object sender, EventArgs e)
        {
            //检查与Thought服务器的连接
            bool viewOnline = await CheckConnect();

            if (!LiteMode.Checked)
            {
                if (viewOnline && MessageBox.Show("是否选择在线文档(推荐)", "已成功连接服务器", MessageBoxButtons.YesNo) == DialogResult.No)
                    viewOnline = false;
                else if (!viewOnline && MessageBox.Show("是否选择本地文档", "连接服务器失败", MessageBoxButtons.YesNo) == DialogResult.No)
                    viewOnline = true;
            }

            if (viewOnline)
            {
                processStartInfo.FileName = Define.POLICY_URL;
                Process.Start(processStartInfo);
            }
            else
            {
                PrivacyForm privacyForm = new(DarkMode.Checked);
                privacyForm.ShowDialog();
            }
        }

        private void FunctionMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (TextBox.SelectionLength > 0)
            {
                e.Cancel = true;
                TextMenu.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void Count_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(TextBox.SelectionLength), "字数统计");
        }
        private void Run_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckStrFormat(Define.URL_REGEX, TextBox.SelectedText))
                {
                    processStartInfo.FileName = "https://" + TextBox.SelectedText;
                    Process.Start(processStartInfo);   //网址
                }
                else if (CheckStrFormat(Define.EMAIL_REGEX, TextBox.SelectedText))
                {
                    processStartInfo.FileName = "mailto:" + TextBox.SelectedText;
                    Process.Start(processStartInfo);   //邮箱
                }
                else
                {
                    processStartInfo.FileName = TextBox.SelectedText;
                    Process.Start(processStartInfo);    //文件路径
                }
            }
            catch   //百度搜索
            {
                if (TextBox.SelectionLength > 3628)
                {
                    processStartInfo.FileName = Define.BAIDU_SEARCH_API + Uri.EscapeDataString(TextBox.SelectedText[..3628]);
                    Process.Start(processStartInfo);    //最长32659(编码后汉字长度x9)
                }
                else
                {
                    processStartInfo.FileName = Define.BAIDU_SEARCH_API + Uri.EscapeDataString(TextBox.SelectedText);
                    Process.Start(processStartInfo);    //正常选择
                }
            }
        }
        private void Translate_Click(object sender, EventArgs e)
        {
            //百度翻译
            if (TextBox.SelectionLength > 32650)
            {
                processStartInfo.FileName = Define.BAIDU_TRANSLATE_API + TextBox.SelectedText[..32655];
                Process.Start(processStartInfo);    //最长32655
            }
            else
            {
                processStartInfo.FileName = Define.BAIDU_TRANSLATE_API + TextBox.SelectedText;
                Process.Start(processStartInfo);   //正常选择
            }
        }

        //拖放
        private void TextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }
        private void TextBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] path = (string[])e.Data.GetData(DataFormats.FileDrop);
                FILE_PATH = path[0];
                ImportFile();
            }
        }
        //热键
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (LockTextBox.Checked)
                return;

            if (e.Control && e.Alt && e.KeyCode == Keys.E)
                TextBox.ContextMenuStrip = TextBox.ContextMenuStrip == null ? FunctionMenu : null;  //切换右键(普通)/(功能)菜单
            else if (e.Control && e.KeyCode == Keys.N)
                Create_Click(Create, new EventArgs());  //创建窗口
            else if (e.Control && e.KeyCode == Keys.W)
                Close_Click(Close, new EventArgs());    //关闭窗口
            else if (e.Control && e.KeyCode == Keys.S)
                Save_Click(Save, new EventArgs());  //保存文件
            else if (e.Alt && e.KeyCode == Keys.S)
                Export_Click(Export, new EventArgs());  //导出文件(另存为)
            else if (e.Control && e.KeyCode == Keys.O)
                Import_Click(Import, new EventArgs());  //导入文件
            else if (e.Control && e.KeyCode == Keys.F)
                Search_Click(Search, new EventArgs());  //查找文本
            else if (e.Control && e.Alt && e.KeyCode == Keys.U)
                ImproveOpacity_Click(ImproveOpacity, new EventArgs());  //透明度+
            else if (e.Control && e.Alt && e.KeyCode == Keys.D)
                ReduceOpacity_Click(ReduceOpacity, new EventArgs());    //透明度-
            else if (e.Control && e.Alt && e.KeyCode == Keys.T)
                AlwaysTop_Click(AlwaysTop, new EventArgs());    //置顶窗口
            else if (e.Control && e.Alt && e.KeyCode == Keys.L)
                LockTextBox_Click(LockTextBox, new EventArgs());    //锁定输入
            else if (e.Control && e.Alt && e.KeyCode == Keys.B)
                DarkMode_Click(DarkMode, new EventArgs());    //夜间模式
            else if (e.Control && e.Alt && e.KeyCode == Keys.R)
                ScrollBar_Click(ScrollBar, new EventArgs());    //(显示)/(隐藏)滑块
            else if (e.Control && e.Alt && e.KeyCode == Keys.H)
                OpenBorder_Click(HideBorder, new EventArgs());    //(隐藏)/(显示)边框
        }
        private void FunctionMenu_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (LockTextBox.Checked)
                return;

            if (e.Control && e.KeyCode == Keys.N)
                Create_Click(Create, new EventArgs());  //创建窗口
            else if (e.Control && e.KeyCode == Keys.W)
                Close_Click(Close, new EventArgs());    //关闭窗口
            else if (e.Control && e.KeyCode == Keys.S)
            {
                FunctionMenu.Close();
                Save_Click(Save, new EventArgs());  //保存文件
            }
            else if (e.Control && e.KeyCode == Keys.O)
            {
                FunctionMenu.Close();
                Import_Click(Import, new EventArgs());  //导入文件
            }
            else if (e.Control && e.KeyCode == Keys.F)
            {
                FunctionMenu.Close();
                Search_Click(Search, new EventArgs());  //查找文本
            }
        }
        //轻模式热键显示
        private void LiteShortcut(bool turnOn)
        {
            if (turnOn)
            {
                Create.ShortcutKeyDisplayString = "(N)";
                Close.ShortcutKeyDisplayString = "(W)";
                Save.ShortcutKeyDisplayString = "(S)";
                Export.ShortcutKeyDisplayString = "(S)";
                Import.ShortcutKeyDisplayString = "(O)";
                Search.ShortcutKeyDisplayString = "(F)";
                ImproveOpacity.ShortcutKeyDisplayString = "(U)";
                ReduceOpacity.ShortcutKeyDisplayString = "(D)";
                AlwaysTop.ShortcutKeyDisplayString = "(T)";
                LockTextBox.ShortcutKeyDisplayString = "(L)";
                DarkMode.ShortcutKeyDisplayString = "(B)";
                ScrollBar.ShortcutKeyDisplayString = "(R)";
                HideBorder.ShortcutKeyDisplayString = "(H)";
            }
            else
            {
                Create.ShortcutKeyDisplayString = "(Ctrl+N)";
                Close.ShortcutKeyDisplayString = "(Ctrl+W)";
                Save.ShortcutKeyDisplayString = "(Ctrl+S)";
                Export.ShortcutKeyDisplayString = "(Alt+S)";
                Import.ShortcutKeyDisplayString = "(Ctrl+O)";
                Search.ShortcutKeyDisplayString = "(Ctrl+F)";
                ImproveOpacity.ShortcutKeyDisplayString = "(Ctrl+Alt+U)";
                ReduceOpacity.ShortcutKeyDisplayString = "(Ctrl+Alt+D)";
                AlwaysTop.ShortcutKeyDisplayString = "(Ctrl+Alt+T)";
                LockTextBox.ShortcutKeyDisplayString = "(Ctrl+Alt+L)";
                DarkMode.ShortcutKeyDisplayString = "(Ctrl+Alt+B)";
                ScrollBar.ShortcutKeyDisplayString = "(Ctrl+Alt+R)";
                HideBorder.ShortcutKeyDisplayString = "(Ctrl+Alt+H)";
            }
        }
        //文件未保存标记
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!CHANGE_MARK)
            {
                Text += "*";
                CHANGE_MARK = true;
            }
        }
        //导入
        private void ImportFile()
        {
            //特殊情况采取的特殊行为
            if (LockTextBox.Checked)
                return;

            if (!System.IO.File.Exists(FILE_PATH) || !LiteMode.Checked && ((Path.GetExtension(FILE_PATH) != ".txt" && Path.GetExtension(FILE_PATH) != ".vtxt")))
            {
                //非正常后缀提示
                MessageBox.Show("请不要往我里面塞奇怪的东西...");
            }

            if (!LiteMode.Checked && TextBox.Text != "")
            {
                //便签有内容，提示用户是否覆盖
                MessageBoxButtons msgButton = MessageBoxButtons.YesNo;

                if (MessageBox.Show("呃...已经有东西了，确定要覆盖吗？", $"{Define.NAME} 的提醒", msgButton) == DialogResult.No)
                    return;
            }

            //读文件
            FileStream importer = new(FILE_PATH, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite | FileShare.Delete);
            StreamReader reader = new(importer);
            //写文本
            TextBox.Text = reader.ReadToEnd();
            TextBox.Select(0, 0);

            Text = Path.GetFileName(FILE_PATH);
            CHANGE_MARK = false;
        }
        //字符串格式匹配
        private static bool CheckStrFormat(string regexRule, string strValue)
        {
            Regex regex = new(regexRule);
            return regex.IsMatch(strValue);
        }
        //Ping检查连接
        private static async Task<bool> CheckConnect()
        {
            Ping ping = new();
            try
            {
                PingReply reply = await ping.SendPingAsync(Define.THOUGHT_PING_URL); //Ping Thought服务器
                if (reply.Status != IPStatus.Success)   //连接失败
                    throw new Exception("NetworkError");
            }
            catch
            {
                return false;
            }

            return true;    //连接成功
        }
    }
}