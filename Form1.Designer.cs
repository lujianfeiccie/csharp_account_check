using System.Data;
using System.Windows.Forms;
namespace AccountCheck
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.网站ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示用户密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于作者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.lwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.网站ToolStripMenuItem,
            this.显示用户密码ToolStripMenuItem,
            this.lwToolStripMenuItem,
            this.刷新ToolStripMenuItem,
            this.关于作者ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(905, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 网站ToolStripMenuItem
            // 
            this.网站ToolStripMenuItem.Name = "网站ToolStripMenuItem";
            this.网站ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.网站ToolStripMenuItem.Text = "选择网站";
            // 
            // 显示用户密码ToolStripMenuItem
            // 
            this.显示用户密码ToolStripMenuItem.Name = "显示用户密码ToolStripMenuItem";
            this.显示用户密码ToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.显示用户密码ToolStripMenuItem.Text = "显示用户密码";
            this.显示用户密码ToolStripMenuItem.Click += new System.EventHandler(this.显示用户密码ToolStripMenuItem_Click);
            // 
            // 关于作者ToolStripMenuItem
            // 
            this.关于作者ToolStripMenuItem.Name = "关于作者ToolStripMenuItem";
            this.关于作者ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.关于作者ToolStripMenuItem.Text = "关于作者";
            this.关于作者ToolStripMenuItem.Click += new System.EventHandler(this.关于作者ToolStripMenuItem_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 24);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(905, 456);
            this.webBrowser1.TabIndex = 2;
            // 
            // lwToolStripMenuItem
            // 
            this.lwToolStripMenuItem.Name = "lwToolStripMenuItem";
            this.lwToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.lwToolStripMenuItem.Text = "输入网址";
            this.lwToolStripMenuItem.Click += new System.EventHandler(this.lwToolStripMenuItem_Click);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 480);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "网站查询";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 网站ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于作者ToolStripMenuItem;
        private ToolStripMenuItem 显示用户密码ToolStripMenuItem;
        private ToolStripMenuItem lwToolStripMenuItem;
        private ToolStripMenuItem 刷新ToolStripMenuItem;     
     
    }
}

