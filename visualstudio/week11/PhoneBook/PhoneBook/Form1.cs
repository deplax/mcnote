using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        PhoneBook pb;
        public Form1()
        {
            InitializeComponent();
            pb = new PhoneBook();
            //pb.Add("김김김", "없음", "그룹그룹");
            //pb.Add("이이이", "없음", "그룹");
            saveFileDialog1.Filter = "저장파일(*.xml)|*.xml|전부(*.*)|*.*";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!(saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK))
            {
                return;
            }
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.GetEncoding("euc-kr"));
            XmlSerializer xs = new XmlSerializer(typeof(PhoneBook));
            xs.Serialize(sw, pb);
            sw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK))
            {
                return;
            }
            StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.GetEncoding("euc-kr"));
            
            XmlSerializer xs = new XmlSerializer(typeof(PhoneBook));
            PhoneBook pb = (PhoneBook)xs.Deserialize(sr);

            textBox1.Text = pb.GetAllData();
            sr.Close();

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "편집중";
        }
    }
}
