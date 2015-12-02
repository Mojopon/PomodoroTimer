﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    public interface ICountdownTimer
    {
        bool CountdownEnd { get; }

        void Tick();
        void Reset();
        int GetMinute();
        int GetSecond();
    }
}
