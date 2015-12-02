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
    public partial class ConfigForm : Form, IConfigForm
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        public int GetTaskTime()
        {
            return int.Parse(textBoxTaskTime.Text);
        }

        public int GetBreakTime()
        {
            return int.Parse(textBoxBreakTime.Text);
        }

        public int GetLongBreakTime()
        {
            return int.Parse(textBoxLongBreakTime.Text);
        }

        public int GetRepeatTime()
        {
            return int.Parse(textBoxRepeatTime.Text);
        }

        public void DisplayForm()
        {
            Show();
        }

        private void ConfigForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
