using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Threading;

namespace AccountCheck
{
    public partial class Form1 : Form
    {        
         struct WebInfo
         {
             public string title;
             public string link;
             public string id_username;
             public string id_password;
             public string tag_username;
             public string tag_password;
             public string username;
             public string password;
         }
        WebInfo mWebInfo = new WebInfo();
        DataSet ds;//用于存放配置文件信息
        delegate void TipsToWaitDelegate(object obj);
        delegate void CallToNavigateDelegate(WebInfo obj);
        delegate void CallToAddItemDelegate(ToolStripMenuItem obj);
        public Form1()
        {
            InitializeComponent();
          
        }
        FormFirstWait mFormFirstWait = null;
        void showTipsToWait(object obj)
        {
            mFormFirstWait = new FormFirstWait();
            mFormFirstWait.Message = obj.ToString();
            mFormFirstWait.Title = "提示";
            mFormFirstWait.ShowDialog();
        }
        void closeTips(object obj)
        {
            mFormFirstWait.Close();
            mFormFirstWait.Dispose();
            mFormFirstWait = null;
        }
        private void Init() {
            //读配置文件
            ds = new DataSet();
            ds.ReadXml(Application.StartupPath + "\\WebInfo.xml");

            this.BeginInvoke(new TipsToWaitDelegate(showTipsToWait),new object[]{"正在载入数据"});
         
            WebInfo mWebInfo = new WebInfo();
            int i = 0;
            //将读取到的记录添加到下拉菜单
            foreach (DataRowView dr in ds.Tables[0].DefaultView)
            {
                mWebInfo.title = dr["title"].ToString();
                if (i == 0) //第一次载入的页面
                {
                    mWebInfo.link = dr["link"].ToString();
                    mWebInfo.id_password = dr["id_password"].ToString();
                    mWebInfo.id_username = dr["id_username"].ToString();
                    mWebInfo.tag_password = dr["tag_password"].ToString();
                    mWebInfo.tag_username = dr["tag_username"].ToString();
                    mWebInfo.username = dr["username"].ToString();
                    mWebInfo.password = dr["password"].ToString();
                    this.Invoke(new CallToNavigateDelegate(onMySelectedReceive), new object[] { mWebInfo });
                }
                ++i;
                ToolStripMenuItem mToolStripMenuItem = new ToolStripMenuItem();
                mToolStripMenuItem.Name = string.Format("item_{0}", mWebInfo.title);
                mToolStripMenuItem.Text = mWebInfo.title;
                mToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
                mToolStripMenuItem.Click += new System.EventHandler(mToolStripMenuItem_Click);
                this.Invoke(new CallToAddItemDelegate(CallToAddItem),new object[]{mToolStripMenuItem});
            }
            this.Invoke(new TipsToWaitDelegate(closeTips),new object[]{""});                           
        }
        void CallToAddItem(ToolStripMenuItem obj)
        {
            this.网站ToolStripMenuItem.DropDownItems.Add(obj);
        }
        void mToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ToolStripMenuItem mToolStripMenuItem = (ToolStripMenuItem)sender;

            foreach (DataRowView dr in ds.Tables[0].DefaultView)
            {
                string title = dr["title"].ToString();
                if (mToolStripMenuItem.Text.Trim().Equals(title))
                {
                    WebInfo mWebInfo = new WebInfo();
                    mWebInfo.title = dr["title"].ToString();
                    mWebInfo.link = dr["link"].ToString();
                    mWebInfo.id_password = dr["id_password"].ToString();
                    mWebInfo.id_username = dr["id_username"].ToString();
                    mWebInfo.tag_password = dr["tag_password"].ToString();
                    mWebInfo.tag_username = dr["tag_username"].ToString();
                    mWebInfo.username = dr["username"].ToString();
                    mWebInfo.password = dr["password"].ToString();
                    onMySelectedReceive(mWebInfo);
                    break;
                }
            }

        }
        void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (!mWebInfo.id_username.Equals(""))
            {
                webBrowser1.Document.GetElementById(mWebInfo.id_username).SetAttribute("value", mWebInfo.username);
            }
            else if(!mWebInfo.tag_username.Equals(""))
            {
                webBrowser1.Document.All[mWebInfo.tag_username].SetAttribute("value", mWebInfo.username);
            }
            if (!mWebInfo.id_password.Equals(""))
            {
                webBrowser1.Document.GetElementById(mWebInfo.id_password).SetAttribute("value", mWebInfo.password);
            }
            else if (!mWebInfo.tag_password.Equals(""))
            {
                webBrowser1.Document.All[mWebInfo.tag_password].SetAttribute("value", mWebInfo.password);
            }
        }           

        private void 关于作者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About formDlg = new About();
            formDlg.ShowDialog();            
            formDlg.Dispose();
            formDlg = null;
        }
      
        void onMySelectedReceive(WebInfo mWebInfo)
        {
            this.mWebInfo = mWebInfo;
            webBrowser1.Navigate(mWebInfo.link);
        }

        private void 显示用户密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mWebInfo.username == null)
            {
                return;
            }
            if (!mWebInfo.username.Trim().Equals("") &&
                !mWebInfo.password.Trim().Equals(""))
            {
                MessageBox.Show(string.Format("用户名：{0} 密码:{1}", mWebInfo.username, mWebInfo.password),mWebInfo.title);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);                   
            Thread t = new Thread(new ThreadStart(Init));
            t.Start();
        }

        private void lwToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressInput mAddressInput = new AddressInput();
            mAddressInput.onUrlReceive += onUrlReceive;
            mAddressInput.Url = mWebInfo.link;
            mAddressInput.ShowDialog();
        }
        void onUrlReceive(string url) {
            mWebInfo.link = url;
            mWebInfo.id_password = "";
            mWebInfo.id_username = "";
            mWebInfo.tag_password = "";
            mWebInfo.tag_username = "";

            webBrowser1.Navigate(url);
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(mWebInfo.link);
          
        }
    }
}
