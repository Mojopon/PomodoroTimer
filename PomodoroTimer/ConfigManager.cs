using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    public class ConfigManager
    {
        private int taskTime = 25;
        private int breakTime = 5;
        private int repeatTime = 3;
        private int longBreakTime = 15;
        public ConfigManager() { }

        public void ChangePomodoroConfig(int task, int shortBreak, int repeat, int longBreak)
        {
            taskTime = task;
            breakTime = shortBreak;
            repeatTime = repeat;
            longBreakTime = longBreak;
        }

        public IConfig GetConfig()
        {
            var pomodoroConfig = new PomodoroConfig(taskTime, breakTime, repeatTime, longBreakTime);
            var config = new Config(pomodoroConfig);

            return config;
        }
    }
}
