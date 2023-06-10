using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equation_and_Code.Form_About {
    public partial class Form_About : Form {
        public Form_About() {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

        }





        /// <summary>
        /// 哔哩哔哩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logo_bilibili_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://space.bilibili.com/45879248/");
        }





        /// <summary>
        /// GitHub
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logo_github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/LittleNewton/Equation_and_Codebox/");
        }





        /// <summary>
        /// 知乎
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logo_zhihu_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://zhihu.com/people/littleNewton");
        }
    }
}
