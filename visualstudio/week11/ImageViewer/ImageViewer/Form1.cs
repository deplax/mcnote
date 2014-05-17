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

namespace ImageViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "JPG(*.jpg)|*.jpg";
            saveFileDialog1.Filter = "저장파일(*.xml)|*.xml|전부(*.*)|*.*";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(!(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK))
            {
                return;
            }
            Image img = Image.FromFile(openFileDialog1.FileName);
            pictureBox1.Width = img.Width;
            pictureBox1.Height = img.Height;
            pictureBox1.Image = img;
            pictureBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            ImageData ImgData = new ImageData();
            ImgData.SetSize(bmp.Width, bmp.Height);
            for(int i = 0; i < bmp.Height; i++)
            {
                for(int j = 0; j < bmp.Width; j++)
                {
                    ImgData.pixel[i * ImgData.width + j] = bmp.GetPixel(j, i).ToArgb();
                }
            
            }
            if (saveFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            XmlSerializer xs = new XmlSerializer(typeof(ImageData));
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false);
            xs.Serialize(sw, ImgData);
            sw.Close();
        }
    }
}
