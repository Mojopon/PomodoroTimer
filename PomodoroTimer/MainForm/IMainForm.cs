using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    public interface IMainForm : IFormDisplayable, ITimerForm
    {
        event Action OnConfigOpen;
        void DrawTime(int minute, int second);
    }
}
