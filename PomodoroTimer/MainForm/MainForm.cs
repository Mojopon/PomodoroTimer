using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTimer
{
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public event Action OnTimerStart;
        public event Action OnTimerTick;
        public event Action OnTimerEnd;

        public event Action OnConfigOpen;

        public void Run()
        {
            Application.Run(this);
        }

        public void DrawTime(int minute, int second)
        {
            labelMinute.Text = TimeNumberToString(minute);
            labelSecond.Text = TimeNumberToString(second);
        }

        private string TimeNumberToString(int number)
        {
            if(number < 10)
            {
                return "0" + number.ToString();
            }

            return number.ToString();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (OnTimerStart != null)
            {
                OnTimerStart();
                timer.Start();
            }
        }

        private void tick(object sender, EventArgs e)
        {
            if (OnTimerTick != null) OnTimerTick();
        }

        public void TimerEnd()
        {
            timer.Stop();
            MessageBox.Show("Countdown End");
        }

        private void ConfigMenuClick(object sender, EventArgs e)
        {
            if(OnConfigOpen != null)
            {
                OnConfigOpen();
            }
        }
    }
}
