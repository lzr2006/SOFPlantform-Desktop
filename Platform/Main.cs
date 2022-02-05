using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;

namespace Outsourcing_Platform
{
    public partial class Main :UIForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Example
            //TODO:添加依次显示的动画效果
            uiListBox1_Task.Items.Add("绘画人物");

            uiTextBox_GetTaskTitle.ReadOnly = true;
            uiRichTextBox_GetTaskDescription.ReadOnly = true;
        }

        /// <summary>
        /// 加载皮肤处理函数
        /// </summary>
        /// <param name="skinFilePathA">皮肤文件路径</param>
        public void LoadSkinHandler(string skinFilePathA)
        {

        }

        private void uiTextBox1_Click(object sender, EventArgs e)
        {
            if (uiTextBox_PostTaskTitle.Text == "请输入任务标题")
            {
                uiTextBox_PostTaskTitle.ForeColor = Color.Black;
                uiTextBox_PostTaskTitle.Text = string.Empty;
            }
        }

        private void uiTextBox_PostTaskPrise_Click(object sender, EventArgs e)
        {
            if (uiTextBox_PostTaskPrise.Text == "请输入任务价格")
            {
                uiTextBox_PostTaskPrise.ForeColor = Color.Black;
                uiTextBox_PostTaskPrise.Text = "￥：0.00";
                uiTextBox_PostTaskPrise.Select(2, 0);
            }
        }

        private void uiSymbolButton_PostTask_Click(object sender, EventArgs e)
        {
            //发送任务
        }

        private void label_Warning_Click(object sender, EventArgs e)
        {
            MessageBox.Show("警告：若选择了接单，则您必须保证能够完成任务。\n若您单方面违约，造成的损失将由您全权负责。","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
