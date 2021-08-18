using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Vight_Note
{
    public partial class UpdateForm : Form
    {
        private static class Define
        {
            public const string RELEASE_GITHUB_API_URL = @"https://api.github.com/repos/SpaceTimee/Vight-Note/releases/latest";
            public const string ACCEPT_HEADER = @"application/vnd.github.v3+json";
            public const string USER_AGENT_HEADER = @"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.114 Safari/537.36";

            public const string RELEASE_LANZOU_URL = @"https://spacetime.lanzoui.com/b01666yti";
            public const string RELEASE_LANZOU_PASSWORD = @"3a57";

            public static readonly string APPX_ZIP_PATH = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Vight Note Package.zip";
            public static readonly string APPX_PATH = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Vight Note Package";
            public static readonly string EXE_PATH = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Vight Note Setup.exe";

            public static bool IS_LITEMODE = false;
            public static string RELEASE_JSON = @"";
        }

        private static readonly HttpClient client = new HttpClient();

        public UpdateForm(bool isDarkMode, bool isLiteMode)
        {
            InitializeComponent();

            //显示版本号
            LocalVersionLabel.Text = Application.ProductVersion;

            //设定暗色模式
            CheckDarkMode(isDarkMode);

            //记录轻模式
            Define.IS_LITEMODE = isLiteMode;
        }
        private void CheckDarkMode(bool isDarkMode)
        {
            if (isDarkMode)
            {
                BackColor = Color.Black;
                ForeColor = Color.Gray;
            }
        }

        private async void UpdateButton_Click(object sender, System.EventArgs e)
        {
            //获取API返回的Json(不管是否已经获取过)
            if (!await UpdateGetReleaseJson())
                return;

            //解析版本号
            UpdateGetGetReleaseVersion();

            //检查更新结束后判断是否有可用更新
            UpdateGetGetResult();
        }
        private async void GithubButton_Click(object sender, EventArgs e)
        {
            //没有获取过Json
            if (Define.RELEASE_JSON == "")
                if (!await GithubGetReleaseJson())
                    return;

            var result = MessageBox.Show("是否下载APPX包 (否则下载exe包)", "下载地址解析成功", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                //更新APPX包
                if (!await GithubUpdateAppx())
                    return;
                else
                    Close();
            }
            else if (result == DialogResult.No)
            {
                //更新EXE包
                if (!await GithubUpdateExe())
                    return;
                else
                    Close();
            }
        }
        private void LanzouButton_Click(object sender, EventArgs e)
        {
            if (!Define.IS_LITEMODE)
            {
                if (MessageBox.Show($"即将打开光速下载页面，记住我们的密码暗号：{Define.RELEASE_LANZOU_PASSWORD}", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    return;
            }
            else
            {
                if (MessageBox.Show($"密码：{Define.RELEASE_LANZOU_PASSWORD}", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    return;
            }

            Process.Start(Define.RELEASE_LANZOU_URL);

            Close();
        }
        private void EraseButton_Click(object sender, EventArgs e)
        {
            bool isCleared = false;

            TipLabel.Text = "正在清理残留文件";
            if (File.Exists(Define.APPX_ZIP_PATH))
            {
                File.Delete(Define.APPX_ZIP_PATH);
                isCleared = true;
            }
            if (Directory.Exists(Define.APPX_PATH))
            {
                Directory.Delete(Define.APPX_PATH, true);
                isCleared = true;
            }
            if (File.Exists(Define.EXE_PATH))
            {
                File.Delete(Define.EXE_PATH);
                isCleared = true;
            }

            if (!isCleared)
                TipLabel.Text = "已经一滴都不剩啦QAQ";
            else
                TipLabel.Text = "清理成功";
        }

        //UpdateButton_Click中获取API返回的Json
        private async Task<bool> UpdateGetReleaseJson()
        {
            TipLabel.Text = "正在获取版本号";
            Define.RELEASE_JSON = await GetReleaseJson();
            if (Define.RELEASE_JSON == "")
            {
                TipLabel.Text = "版本号获取失败，请重试";
                return false;
            }

            return true;
        }
        //UpdateButton_Click中解析版本号
        private void UpdateGetGetReleaseVersion()
        {
            TipLabel.Text = "正在解析版本号";
            LatestVersionLabel.Text = GetReleaseVersion();
        }
        //UpdateButton_Click中判断是否有可用更新
        private void UpdateGetGetResult()
        {
            if (LocalVersionLabel.Text != LatestVersionLabel.Text)
                TipLabel.Text = "有可用更新";
            else
                TipLabel.Text = "当前是最新版本";
        }

        //GithubButton_Click中获取API返回的Json
        private async Task<bool> GithubGetReleaseJson()
        {
            TipLabel.Text = "正在获取版本号";
            Define.RELEASE_JSON = await GetReleaseJson();

            if (Define.RELEASE_JSON == "")
            {
                TipLabel.Text = "版本号获取失败，请重试";
                return false;
            }

            return true;
        }
        //GithubButton_Click中更新APPX包
        private async Task<bool> GithubUpdateAppx()
        {
            //解析安装包
            TipLabel.Text = "正在解析安装包";
            string releaseUrl = GetReleaseUrl(true);

            //下载安装包
            TipLabel.Text = "正在下载安装包";
            if (!await GetRelease(releaseUrl, Define.APPX_ZIP_PATH))
            {
                TipLabel.Text = "安装包下载失败，请重试";
                return false;
            }

            //解压安装包
            TipLabel.Text = "正在解压安装包";
            if (!GetAppxFolder())
            {
                TipLabel.Text = "安装包解压失败，请重试";
                return false;
            }

            //打开安装包
            TipLabel.Text = "解压成功";
            Process.Start(Define.APPX_PATH);

            return true;
        }
        //GithubButton_Click中更新EXE包
        private async Task<bool> GithubUpdateExe()
        {
            //解析安装包
            TipLabel.Text = "正在解析安装包";
            string releaseUrl = GetReleaseUrl(false);

            //下载安装包
            TipLabel.Text = "正在下载安装包";
            if (!await GetRelease(releaseUrl, Define.EXE_PATH))
            {
                TipLabel.Text = "安装包下载失败，请重试";
                return false;
            }

            //打开安装包
            TipLabel.Text = "下载成功";
            Process.Start(Define.EXE_PATH);

            return true;
        }

        //获取API返回的sting类型的json
        private async Task<string> GetReleaseJson()
        {
            //设置消息头
            client.DefaultRequestHeaders.Add("Accept", Define.ACCEPT_HEADER);
            client.DefaultRequestHeaders.Add("User-Agent", Define.USER_AGENT_HEADER);

            try
            {
                return await client.GetStringAsync(Define.RELEASE_GITHUB_API_URL);  //获取Json并返回
            }
            catch   //(HttpRequestException e)
            {
                return "";
            }
        }
        //反序列化获取最新版本号
        private string GetReleaseVersion()
        {
            //将Json转换为JObject
            JObject releaseJObject = JObject.Parse(Define.RELEASE_JSON);

            //提取版本号
            return releaseJObject["name"].ToString();
        }
        //反序列化获取下载链接
        private string GetReleaseUrl(bool isPackage)
        {
            //将Json转换为JObject
            JObject releaseJObject = JObject.Parse(Define.RELEASE_JSON);

            //提取下载地址(如果[0]不符合则返回[1]否则返回[0])
            return (isPackage ^ releaseJObject["assets"][0]["browser_download_url"].ToString().Contains("Package")) ?
                releaseJObject["assets"][1]["browser_download_url"].ToString() : releaseJObject["assets"][0]["browser_download_url"].ToString();
        }
        //下载更新文件
        private async Task<bool> GetRelease(string releaseUrl, string filePath)
        {
            //设置消息头
            client.DefaultRequestHeaders.Add("User-Agent", Define.USER_AGENT_HEADER);

            //下载
            try
            {
                byte[] bytes = await client.GetByteArrayAsync(releaseUrl);

                //写入本地文件
                FileStream saver = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite | FileShare.Delete);
                saver.Write(bytes, 0, bytes.Length);
                saver.Close();
            }
            catch   //(HttpRequestException e)
            {
                return false;
            }

            return true;
        }
        //解压APPX的zip包
        private bool GetAppxFolder()
        {
            //如果已经有解压后的文件夹则删除
            if (Directory.Exists(Define.APPX_PATH))
                Directory.Delete(Define.APPX_PATH, true);

            //解压
            try
            {
                ZipFile.ExtractToDirectory(Define.APPX_ZIP_PATH, Define.APPX_PATH);
            }
            catch
            {
                return false;
            }

            return true;
        }
        //热键
        private void UpdateForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();    //关闭窗口
        }
    }
}
