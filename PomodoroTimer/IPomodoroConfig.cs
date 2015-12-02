using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    public interface IPomodoroConfig
    {
        int TaskTime { get; }
        int BreakTime { get; }
        int RepeatTime { get; }
        int LongBreakTime { get; }
    }
}
