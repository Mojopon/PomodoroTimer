using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    public class Config : IConfig
    {
        private IPomodoroConfig pomodoroConfig;
        public Config(IPomodoroConfig pomodoroConfig)
        {
            this.pomodoroConfig = pomodoroConfig;
        }

        public void ConfigurePomodoro(IConfigurablePomodoro pomodoro)
        {
            pomodoro.Configure(pomodoroConfig);
        }
    }
}
