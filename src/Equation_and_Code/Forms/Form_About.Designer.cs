
namespace Equation_and_Code.Form_About {
    partial class Form_About {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_About));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.logo_zhihu = new System.Windows.Forms.PictureBox();
            this.logo_github = new System.Windows.Forms.PictureBox();
            this.logo_bilibili = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_zhihu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_github)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_bilibili)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1712, 148);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Equation_and_Code.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(41, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.logo_zhihu);
            this.panel2.Controls.Add(this.logo_github);
            this.panel2.Controls.Add(this.logo_bilibili);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 778);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1712, 166);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(865, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Copyrights 2023. All rights reserved by Peng Liu, aka. littlenewton.";
            // 
            // logo_zhihu
            // 
            this.logo_zhihu.Image = global::Equation_and_Code.Properties.Resources.icons8_zhihu_512px_1;
            this.logo_zhihu.Location = new System.Drawing.Point(1574, 49);
            this.logo_zhihu.Name = "logo_zhihu";
            this.logo_zhihu.Size = new System.Drawing.Size(91, 85);
            this.logo_zhihu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_zhihu.TabIndex = 0;
            this.logo_zhihu.TabStop = false;
            this.logo_zhihu.Click += new System.EventHandler(this.logo_zhihu_Click);
            // 
            // logo_github
            // 
            this.logo_github.Image = global::Equation_and_Code.Properties.Resources.icons8_github_512px;
            this.logo_github.Location = new System.Drawing.Point(1450, 49);
            this.logo_github.Name = "logo_github";
            this.logo_github.Size = new System.Drawing.Size(91, 85);
            this.logo_github.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_github.TabIndex = 0;
            this.logo_github.TabStop = false;
            this.logo_github.Click += new System.EventHandler(this.logo_github_Click);
            // 
            // logo_bilibili
            // 
            this.logo_bilibili.Image = global::Equation_and_Code.Properties.Resources.icons8_bilibili_480px;
            this.logo_bilibili.Location = new System.Drawing.Point(1321, 49);
            this.logo_bilibili.Name = "logo_bilibili";
            this.logo_bilibili.Size = new System.Drawing.Size(91, 85);
            this.logo_bilibili.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_bilibili.TabIndex = 0;
            this.logo_bilibili.TabStop = false;
            this.logo_bilibili.Click += new System.EventHandler(this.logo_bilibili_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 10.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(41, 185);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1628, 555);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Form_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1712, 944);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "Form_About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_zhihu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_github)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_bilibili)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox logo_bilibili;
        private System.Windows.Forms.PictureBox logo_zhihu;
        private System.Windows.Forms.PictureBox logo_github;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}