using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Vight_Note
{
    public partial class UpdateForm : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public static class Define
        {
            public const string RELEASE_GITHUB_API_URL = @"https://api.github.com/repos/SpaceTimee/Vight-Note/releases/latest";
            public const string GITHUBUSERCONTENT_PING_URL = @"github-releases.githubusercontent.com";
            public const string ACCEPT_HEADER = @"application/vnd.github.v3+json";
            public const string USER_AGENT_HEADER = @"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.114 Safari/537.36";

            public const string RELEASE_LANZOU_URL = @"https://spacetime.lanzoui.com/b01666yti";
            public const string RELEASE_LANZOU_PASSWORD = @"3a57";

            public static readonly string APPX_ZIP_PATH = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Vight Note Package.zip";
            public static readonly string APPX_PATH = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Vight Note Package";
            public static readonly string EXE_PATH = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Vight Note Setup.exe";

            public static bool IS_LITEMODE = false;
            public static string RELEASE_JSON = @"";
        }

        public UpdateForm(bool isLiteMode)
        {
            InitializeComponent();

            //显示版本号
            LocalVersionLabel.Text = Application.ProductVersion;

            //记录轻模式
            Define.IS_LITEMODE = isLiteMode;
        }

        private async void UpdateButton_Click(object sender, System.EventArgs e)
        {
            //获取API返回的Json
            if (!await GetReleaseJsonStep())
                return;

            //解析版本号
            TipLabel.Text = "正在解析版本号";
            LatestVersionLabel.Text = GetReleaseVersion();

            //检查更新结束后的处理
            if (LocalVersionLabel.Text != LatestVersionLabel.Text)
                TipLabel.Text = "有可用更新";
            else
                TipLabel.Text = "当前是最新版本";
        }
        private void EraseButton_Click(object sender, EventArgs e)
        {
            TipLabel.Text = "正在清理残留文件";

            if (File.Exists(Define.APPX_ZIP_PATH))
                File.Delete(Define.APPX_ZIP_PATH);
            if (Directory.Exists(Define.APPX_PATH))
                Directory.Delete(Define.APPX_PATH, true);
            if (File.Exists(Define.EXE_PATH))
                File.Delete(Define.EXE_PATH);

            TipLabel.Text = "清理成功";
        }
        private async void GithubButton_Click(object sender, EventArgs e)
        {
            //判断是否已获取过Json
            if (Define.RELEASE_JSON == "")
            {
                //获取API返回的Json
                if (!await GetReleaseJsonStep())
                    return;
            }

            var result = MessageBox.Show("是否下载APPX包 (否则下载exe包)", "下载地址解析成功", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                //解析安装包
                TipLabel.Text = "正在解析安装包";
                string releaseUrl = GetReleaseUrl(true);

                //下载安装包
                TipLabel.Text = "正在下载安装包";
                if (!await GetRelease(releaseUrl, Define.APPX_ZIP_PATH))
                {
                    TipLabel.Text = "安装包下载失败，请重试";
                    return;
                }

                //解压安装包
                TipLabel.Text = "正在解压安装包";
                GetAppxFolder();

                //打开安装包
                TipLabel.Text = "解压成功";
                Process.Start(Define.APPX_PATH);

                Close();
            }
            else if (result == DialogResult.No)
            {
                //解析安装包
                TipLabel.Text = "正在解析安装包";
                string releaseUrl = GetReleaseUrl(false);

                //下载安装包
                TipLabel.Text = "正在下载安装包";
                if (!await GetRelease(releaseUrl, Define.EXE_PATH))
                {
                    TipLabel.Text = "安装包下载失败，请重试";
                    return;
                }

                //打开安装包
                TipLabel.Text = "解压成功";
                Process.Start(Define.EXE_PATH);

                Close();
            }
        }
        private void LanzouButton_Click(object sender, EventArgs e)
        {
            if (!Define.IS_LITEMODE)
                MessageBox.Show($"即将打开光速下载页面，记住我们的密码暗号：{Define.RELEASE_LANZOU_PASSWORD}");
            else
                MessageBox.Show($"密码：{Define.RELEASE_LANZOU_PASSWORD}");

            Process.Start(Define.RELEASE_LANZOU_URL);

            Close();
        }

        //包含Ping和获取Json的步骤
        public async Task<bool> GetReleaseJsonStep()
        {
            //检测Github服务器连接
            TipLabel.Text = "正在连接服务器";
            if (!await CheckConnect())
            {
                TipLabel.Text = "服务器连接失败，请重试";
                return false;
            }

            //获取API返回的Json
            TipLabel.Text = "正在获取版本号";
            Define.RELEASE_JSON = await GetReleaseJson();
            if (Define.RELEASE_JSON == "")
            {
                TipLabel.Text = "版本号获取失败，请重试";
                return false;
            }

            return true;
        }
        //Ping检查连接
        private async Task<bool> CheckConnect()
        {
            Ping ping = new Ping();
            try
            {
                PingReply reply = await ping.SendPingAsync(Define.GITHUBUSERCONTENT_PING_URL); //Ping Github服务器
                if (reply.Status == IPStatus.Success)   //连接成功
                    return true;
                else
                    throw new Exception("NetworkError");
            }
            catch   //连接失败
            {
                return false;
            }
        }
        //获取Github API返回的sting类型的json
        public async Task<string> GetReleaseJson()
        {
            //设置消息头
            client.DefaultRequestHeaders.Add("Accept", Define.ACCEPT_HEADER);
            client.DefaultRequestHeaders.Add("User-Agent", Define.USER_AGENT_HEADER);

            try
            {
                //获取Json
                return await client.GetStringAsync(Define.RELEASE_GITHUB_API_URL);
            }
            catch   //(HttpRequestException e)
            {
                return "";
            }
        }
        //反序列化获取最新版本号
        public string GetReleaseVersion()
        {
            //将Json转换为JObject
            JObject releaseJObject = JObject.Parse(Define.RELEASE_JSON);

            //提取版本号
            return releaseJObject["name"].ToString();
        }
        //反序列化获取下载链接
        public string GetReleaseUrl(bool isPackage)
        {
            //将Json转换为JObject
            JObject releaseJObject = JObject.Parse(Define.RELEASE_JSON);

            //提取下载地址
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

                return true;
            }
            catch   //(HttpRequestException e)
            {
                return false;
            }
        }
        //解压APPX的zip包
        public void GetAppxFolder()
        {
            //如果已经有解压后的文件夹则删除
            if (Directory.Exists(Define.APPX_PATH))
                Directory.Delete(Define.APPX_PATH, true);

            //解压
            ZipFile.ExtractToDirectory(Define.APPX_ZIP_PATH, Define.APPX_PATH);
        }
    }
}
