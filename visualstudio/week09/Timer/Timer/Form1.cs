using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
        public partial class Form1 : Form
        {
	int stopWatchStampms = 0;
	int stopWatchPausems = 0;
	int stopWatchPauseStart = 0;
	int stopWatchPauseStop = 0;
	int stopwatchms = 0;
	bool stopWatchSW = true;
	int stopWatchState = 0;			        //0초기, 1작동, 2일시정지

	int timerStampms = 0;
	int timerTime = 0;
	int timerPausems = 0;
	int timerPauseStart = 0;
	int timerPauseStop = 0;
	int timerAllms = 0;
	bool timerSW = true;
	int timerState = 0;			        //0초기, 1작동, 2일시정지

	public Form1()
	{
	        InitializeComponent();

	}


	private void Form1_Load(object sender, EventArgs e)
	{
	        radiowatch.Checked = true;
	}

	private void radiowatch_CheckedChanged(object sender, EventArgs e)
	{
	        if (radiowatch.Checked)			//시계 선택시
	        {
		timerwatch.Interval = 10;
		timerwatch.Enabled = true;
		button1.Enabled = false;
		button2.Enabled = false;
	        }
	        else if (radiostopwatch.Checked)		//스톱워치 선택시
	        {
		button1.Enabled = true;
		button2.Enabled = true;
		if (stopWatchState == 0)			//초기상태
		{
		        label1.Text = String.Format("00:00:00:00");
		        button1.Text = "시작";
		        button2.Text = "기록";
		}
		else if (stopWatchState == 1)		//작동중
		{
		        button1.Text = "일시정지";
		        button2.Text = "기록";
		}
		else					//일시정지
		{
		        int ms = 0, s = 0, m = 0, h = 0;
		        timeDevide(ref stopwatchms, ref ms, ref s, ref m, ref h);
		        label1.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", h, m, s, ms);
		        button1.Text = "다시시작";
		        button2.Text = "초기화";
		}
	        }
	        else
	        {						//타이머 선택시
		button1.Enabled = true;
		button2.Enabled = true;
		if (timerState == 0)
		{
		        label1.Text = String.Format("00:00:00:00");
		        button1.Text = "시작";
		        button2.Text = "초기화";
		}
		else if (timerState == 1)
		{
		        button1.Text = "일시정지";
		        button2.Text = "초기화";
		}
		else
		{
		        int ms = 0, s = 0, m = 0, h = 0;
		        timeDevide(ref timerAllms, ref ms, ref s, ref m, ref h);
		        label1.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", h, m, s, ms);
		        button1.Text = "다시시작";
		        button2.Text = "초기화";
		}

	        }
	}

	private void GetTimeNow(ref int h, ref int m, ref int s, ref int ms)
	{
	        h = System.DateTime.Now.Hour;
	        m = System.DateTime.Now.Minute;
	        s = System.DateTime.Now.Second;
	        ms = System.DateTime.Now.Millisecond;
	}

	private void timerwatch_Tick(object sender, EventArgs e)			//시계
	{
	        int h = 0, m = 0, s = 0, ms = 0;
	        GetTimeNow(ref h, ref m, ref s, ref ms);
	        if (radiowatch.Checked)
		label1.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", h, m, s, ms % 1000 / 10);
	}

	private void timeDevide(ref int time, ref int ms, ref int s, ref int m, ref int h)
	{
	        ms = time % 1000 / 10;
	        s = time / 1000 % 60;
	        m = time / 1000 / 60 % 60;
	        h = time / 1000 / 60 / 60 % 60;
	}

	private void timerstopwatch_Tick(object sender, EventArgs e)		        //스톱워치
	{
	        int h = 0, m = 0, s = 0, ms = 0;
	        GetTimeNow(ref h, ref m, ref s, ref ms);

	        if (stopWatchSW)
	        {
		stopWatchStampms = ms + s * 1000 + m * 1000 * 60 + h * 1000 * 60 * 60;	//타이머 시작시간 스탬프
		stopWatchSW = false;
	        }

	        int currentms = ms + s * 1000 + m * 1000 * 60 + h * 1000 * 60 * 60;			//현재시간 스탬프

	        stopwatchms = currentms - stopWatchStampms - stopWatchPausems;
	        int stms = 0, sts = 0, stm = 0, sth = 0;
	        timeDevide(ref stopwatchms, ref stms, ref sts, ref stm, ref sth);

	        if (radiostopwatch.Checked)
		label1.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", sth, stm, sts, stms);

	}

	private void timer_Tick(object sender, EventArgs e)				//타이머
	{
	        int h = 0, m = 0, s = 0, ms = 0;
	        GetTimeNow(ref h, ref m, ref s, ref ms);
	        if (timerSW)
	        {
		timerStampms = ms + s * 1000 + m * 1000 * 60 + h * 1000 * 60 * 60;
		timerSW = false;
	        }


	        int currentms = ms + s * 1000 + m * 1000 * 60 + h * 1000 * 60 * 60;
	        timerAllms = timerTime - (currentms - timerStampms) + timerPausems;
	        int stms = 0, sts = 0, stm = 0, sth = 0;

	        if (timerAllms <= 0)
	        {
		timerAllms = 0;
		timerState = 0;
		timerStampms = 0;
		timerPausems = 0;
		timerPauseStart = 0;
		timerPauseStop = 0;
		timerState = 0;
		button1.Text = "시작";
		button2.Text = "초기화";
		timer.Enabled = false;
		timerSW = true;
		//소리 들려야지요...
	        }

	        timeDevide(ref timerAllms, ref stms, ref sts, ref stm, ref sth);



	        if (radiotimer.Checked)
		label1.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", sth, stm, sts, stms);
	}

	private void button1_Click(object sender, EventArgs e)
	{
	        if (radiowatch.Checked) { }		        //시계일때
	        else if (radiostopwatch.Checked)	        //스톱워치때
	        {
		if (stopWatchState == 0)		        //초기상태	중지      기록
		{
		        timerstopwatch.Interval = 10;
		        timerstopwatch.Enabled = true;
		        button1.Text = "일시정지";
		        button2.Text = "기록";
		        stopWatchState = 1;
		}
		else if (stopWatchState == 1)	        //작동중	일시정지    기록
		{
		        timerstopwatch.Enabled = false;
		        button1.Text = "다시시작";
		        button2.Text = "초기화";
		        stopWatchState = 2;

		        int h = 0, m = 0, s = 0, ms = 0;
		        GetTimeNow(ref h, ref m, ref s, ref ms);
		        stopWatchPauseStart = ms + s * 1000 + m * 1000 * 60 + h * 1000 * 60 * 60;

		}
		else
		{				        //일시정지	다시시작    초기화
		        timerstopwatch.Interval = 10;
		        timerstopwatch.Enabled = true;
		        button1.Text = "일시정지";
		        button2.Text = "기록";
		        stopWatchState = 1;

		        int h = 0, m = 0, s = 0, ms = 0;
		        GetTimeNow(ref h, ref m, ref s, ref ms);
		        stopWatchPauseStop = ms + s * 1000 + m * 1000 * 60 + h * 1000 * 60 * 60;
		        stopWatchPausems += (stopWatchPauseStop - stopWatchPauseStart);

		}

	        }
	        else
	        {					        //타이머 때
		if (timerState == 0)		        //정지상태
		{
		        timer.Interval = 10;
		        timer.Enabled = true;

		        button1.Text = "일시정지";
		        button2.Text = "초기화";
		        timerState = 1;
		        if (textBox1.Text == "")
			textBox1.Text = "0";
		        if (textBox2.Text == "")
			textBox2.Text = "0";
		        if (textBox3.Text == "")
			textBox3.Text = "0";
		        int timerh = Convert.ToInt32(textBox1.Text);
		        int timerm = Convert.ToInt32(textBox2.Text);
		        int timers = Convert.ToInt32(textBox3.Text);

		        timerTime = timers * 1000 + timerm * 1000 * 60 + timerh * 1000 * 60 * 60;
		}
		else if (timerState == 1)		//작동중
		{
		        timer.Enabled = false;
		        button1.Text = "다시시작";
		        button2.Text = "초기화";
		        timerState = 2;
		        int h = 0, m = 0, s = 0, ms = 0;
		        GetTimeNow(ref h, ref m, ref s, ref ms);
		        timerPauseStart = ms + s * 1000 + m * 1000 * 60 + h * 1000 * 60 * 60;
		}
		else				//일시정지
		{
		        timer.Interval = 10;
		        timer.Enabled = true;
		        button1.Text = "일시정지";
		        button2.Text = "초기화";
		        timerState = 1;

		        int h = 0, m = 0, s = 0, ms = 0;
		        GetTimeNow(ref h, ref m, ref s, ref ms);
		        timerPauseStop = ms + s * 1000 + m * 1000 * 60 + h * 1000 * 60 * 60;
		        timerPausems += (timerPauseStop - timerPauseStart);
		}

	        }
	}
	private void button2_Click(object sender, EventArgs e)
	{
	        if (radiowatch.Checked) { }		        //시계일때
	        else if (radiostopwatch.Checked)	        //스톱워치때
	        {
		if (stopWatchState == 0) { }	        //초기상태
		else if (stopWatchState == 1)	        //작동중	기록
		{
		        label2.Text += "\r\n" + label1.Text;
		}
		else				        //일시정지    초기화
		{
		        label1.Text = String.Format("00:00:00:00");
		        label2.Text = "--------------------------";
		        stopWatchStampms = 0;
		        stopWatchPausems = 0;
		        stopWatchPauseStart = 0;
		        stopWatchPauseStop = 0;
		        stopWatchState = 0;
		        button1.Text = "시작";
		        button2.Text = "기록";
		        timerstopwatch.Enabled = false;
		        stopWatchSW = true;
		}

	        }
	        else
	        {					          //타이머 때
		label1.Text = String.Format("00:00:00:00");
		label2.Text = "--------------------------";
		timerStampms = 0;
		timerPausems = 0;
		timerPauseStart = 0;
		timerPauseStop = 0;
		timerState = 0;
		button1.Text = "시작";
		button2.Text = "초기화";
		timer.Enabled = false;
		timerSW = true;

	        }
	}


        }
}
