using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        client client = new client();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string address = textBox2.Text;
            int port = (int)numericUpDown1.Value;
            string result = client.Connect(address, port);

            if(result == "success")
            {
                labeldebug.Text = result;
            }
            else
            {
                textBox1.Text = result;
            }
            labeldebug.Text = result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            client.Disconnect();
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            string msg = "";
            if (e.KeyCode == Keys.Enter)
            {
                msg = client.Send(textBox2.Text);
                textBox1.Text += msg + "\r\n";
            }
        }
    }
}
