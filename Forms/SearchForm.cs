using System;
using System.Windows.Forms;

namespace Vight_Note.Forms
{
    public partial class SearchForm : Form
    {
        public static class Define
        {
            public static MainForm MAIN_FORM;

            public static string SEARCH_TEXT = "";
            public static int START_INDEX = -1, SELECT_LENGTH = 0;
            public static int SEARCH_NUM = 0;
        }

        public SearchForm(MainForm mainForm)
        {
            InitializeComponent();

            //记录mainForm
            Define.MAIN_FORM = mainForm;
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

            //一次新的查找
            if (SearchBox.Text.Trim() != Define.SEARCH_TEXT)
            {
                Define.SEARCH_TEXT = SearchBox.Text.Trim();
                Define.START_INDEX = -1;
                Define.SELECT_LENGTH = Define.SEARCH_TEXT.Length;
                Define.SEARCH_NUM = 0;
            }

            Define.START_INDEX = Define.MAIN_FORM.TextBox.Text.IndexOf(Define.SEARCH_TEXT, Define.START_INDEX + 1);

            if (Define.START_INDEX != -1)
            {
                //有查找结果
                Define.MAIN_FORM.TextBox.Select(Define.START_INDEX, Define.SELECT_LENGTH);
                Text = $"查找文本 (No.{++Define.SEARCH_NUM})";
            }
            else
            {
                //无查找结果或已到文本末尾
                Define.START_INDEX = Define.MAIN_FORM.TextBox.Text.IndexOf(Define.SEARCH_TEXT);

                if (Define.START_INDEX != -1)
                {
                    //已到文本末尾(提前查找一次)
                    Define.MAIN_FORM.TextBox.Select(Define.START_INDEX, Define.SELECT_LENGTH);
                    Define.SEARCH_NUM = 1;
                    Text = $"查找文本 (No.1)";
                }
                else
                {
                    //无查找结果
                    Define.MAIN_FORM.TextBox.Select(0, 0);
                    Text = $"查找文本 (无结果)";
                }
            }

            //控制TextBox滚动，使选中的内容始终可见
            Define.MAIN_FORM.TextBox.ScrollToCaret();
        }

        //热键
        private void SearchForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();    //关闭窗口
        }
    }
}
