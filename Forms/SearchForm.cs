using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vight_Note.Forms
{
    public partial class SearchForm : Form
    {
        private static class Define
        {
            public static MainForm MAIN_FORM;
        }

        private string SEARCH_TEXT = "";
        private int START_INDEX = -1, SELECT_LENGTH = 0;
        private int SEARCH_NUM = 0;

        public SearchForm(MainForm mainForm, bool isDarkMode)
        {
            InitializeComponent();

            //设定暗色模式
            CheckDarkMode(isDarkMode);

            //记录mainForm
            Define.MAIN_FORM = mainForm;
        }
        private void CheckDarkMode(bool isDarkMode)
        {
            if (isDarkMode)
            {
                BackColor = Color.Black;
                ForeColor = Color.Gray;
                SearchBox.BackColor = Color.Black;
                SearchBox.ForeColor = Color.Gray;
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchButton.BackgroundImage = Vight_Note.Properties.Resources.Search;
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            //输入结果为空
            if (SearchBox.Text.Trim() == "")
            {
                Define.MAIN_FORM.TextBox.Select(0, 0);
                Text = $"查找文本";

                return;
            }

            //开始一次新的查找
            NewSearch();

            //控制TextBox滚动，使选中的内容始终可见
            Define.MAIN_FORM.TextBox.ScrollToCaret();
        }

        //一次新的查找
        private void NewSearch()
        {
            if (SearchBox.Text.Trim() != SEARCH_TEXT)
            {
                SEARCH_TEXT = SearchBox.Text.Trim();
                START_INDEX = -1;
                SELECT_LENGTH = SEARCH_TEXT.Length;
                SEARCH_NUM = 0;
            }

            START_INDEX = Define.MAIN_FORM.TextBox.Text.IndexOf(SEARCH_TEXT, START_INDEX + 1);

            if (START_INDEX != -1)
            {
                //有查找结果
                Define.MAIN_FORM.TextBox.Select(START_INDEX, SELECT_LENGTH);
                Text = $"查找文本 (No.{++SEARCH_NUM})";
                SearchButton.BackgroundImage = Vight_Note.Properties.Resources.Reduce;
            }
            else
            {
                //无查找结果或已到文本末尾
                START_INDEX = Define.MAIN_FORM.TextBox.Text.IndexOf(SEARCH_TEXT);

                if (START_INDEX != -1)
                {
                    //已到文本末尾(提前查找一次)
                    Define.MAIN_FORM.TextBox.Select(START_INDEX, SELECT_LENGTH);
                    SEARCH_NUM = 1;
                    Text = $"查找文本 (No.1)";
                }
                else
                {
                    //无查找结果
                    Define.MAIN_FORM.TextBox.Select(0, 0);
                    Text = $"查找文本 (无结果)";
                }
            }
        }

        //热键
        private void SearchForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();    //关闭窗口
        }
    }
}
