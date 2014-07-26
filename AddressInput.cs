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
    public partial class AddressInput : Form
    {
        public delegate void onUrlReceiveDelegate(string msg);

        public onUrlReceiveDelegate onUrlReceive;

        public string Url{
            set { textBox1.Text = value; }
            get { return textBox1.Text;  }
        }
        public AddressInput()
        {
            InitializeComponent();
        }

        private void AddressInput_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Url = textBox1.Text;
            if (onUrlReceive != null)
            {
                onUrlReceive(textBox1.Text);
            }
            Close();
        }
    }
}
