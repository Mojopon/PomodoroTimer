using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    public interface IConfigForm : IFormDisplayable
    {
        int GetTaskTime();
        int GetBreakTime();
        int GetRepeatTime();
        int GetLongBreakTime();
    }
}
