using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    public interface IApplicationController
    {
        void Run(App application);
        void Execute(ICommand command);
    }
}
