using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccountCheck
{
    public partial class FormFirstWait : Form
    {
        public string Message
        {
            set { label1.Text = value; }
            get { return label1.Text;  }
        }
        public string Title
        {
            set { this.Text = value; }
            get { return this.Text; }
        }
        public FormFirstWait()
        {
            InitializeComponent();
        }

        private void FormFirstWait_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
    }
}
