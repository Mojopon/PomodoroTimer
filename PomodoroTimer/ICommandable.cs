using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    public interface ICommandable
    {
        void ProcessCommand(ICommand command);
    }
}
