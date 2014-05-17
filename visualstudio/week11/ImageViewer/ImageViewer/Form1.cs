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
	        openFileDialog2.Filter = "XML(*.xml)|*.xml";

	}

	private void Form1_Load(object sender, EventArgs e)
	{

	}

	private void button2_Click(object sender, EventArgs e)		        //xml 저장하기
	{
	        Bitmap bmp = new Bitmap(pictureBox1.Image);		        //비트맵 형식으로 픽쳐박스 이미지 받음
	        ImageData ImgData = new ImageData();			        //이미지 데이터 클래스 생성
	        ImgData.SetSize(bmp.Width, bmp.Height);			        //가로 세로 받아와서 입력
	        for (int i = 0; i < bmp.Height; i++)				        //세로루프
	        {
		for (int j = 0; j < bmp.Width; j++)				        //가로루프
		{
		        ImgData.pixel[i * ImgData.width + j] = bmp.GetPixel(j, i).ToArgb();	        //픽셀당 색상값 넣기
		}

	        }
	        if (saveFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
	        {
		return;
	        }
	        XmlSerializer xs = new XmlSerializer(typeof(ImageData));		        //이미지데이터 타입으로 시리얼라이즈 
	        StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false);	        //스트림 라이터
	        xs.Serialize(sw, ImgData);						        //기록
	        sw.Close();							        //닫기
	}

	private void button1_Click(object sender, EventArgs e)		        //불러오기
	{
	        if (!(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK))
	        {
		return;
	        }
	        Image img = Image.FromFile(openFileDialog1.FileName);
	        pictureBox1.Width = img.Width;
	        pictureBox1.Height = img.Height;
	        pictureBox1.Image = img;
	        pictureBox1.Refresh();
	}

	private void button3_Click(object sender, EventArgs e)		        //xml불러오기
	{
	        if (!(openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK))
	        {
		return;
	        }
	        StreamReader sr = new StreamReader(openFileDialog2.FileName, Encoding.GetEncoding("euc-kr"));
	        XmlSerializer xs = new XmlSerializer(typeof(ImageData));
	        ImageData imgData = (ImageData)xs.Deserialize(sr);
	        sr.Close();

	        Bitmap bmp = new Bitmap(imgData.width, imgData.height);

	        for (int i = 0; i < imgData.height; i++)
	        {
		for (int j = 0; j < imgData.width; j++)
		{
		        bmp.SetPixel(j, i, Color.FromArgb(imgData.pixel[i * imgData.width + j]));
		        imgData.pixel[i * imgData.width + j] = bmp.GetPixel(j, i).ToArgb();
		}
	        }

	        pictureBox1.Image = bmp;



	}

	private void button4_Click(object sender, EventArgs e)
	{
	        pictureBox1.Image = null;
	}
        }
}
