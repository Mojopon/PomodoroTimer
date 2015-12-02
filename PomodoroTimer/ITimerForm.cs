using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    public interface ITimerForm
    {
        event Action OnTimerTick;
        event Action OnTimerStart;
        event Action OnTimerEnd;
        void TimerEnd();
    }
}
