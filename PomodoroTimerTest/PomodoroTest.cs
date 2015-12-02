﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PomodoroTimer;

namespace PomodoroTimerTest
{
    [TestFixture]
    public class PomodoroTest
    {
        private Pomodoro pomodoro;

        [SetUp]
        public void CreatePomodoro()
        {
            pomodoro = new Pomodoro();

            int task = 2;
            int shortBreak = 1;
            int repeat = 2;
            int longBreak= 3;

            var pomodoroConfig = new PomodoroConfig(task, shortBreak, repeat, longBreak);

            pomodoro.Configure(pomodoroConfig);
        }

        [Test]
        public void ShouldSwitchTaskCountdownAndBreakCountdown()
        {
            Assert.AreEqual(2, pomodoro.GetMinute());
            Assert.AreEqual(0, pomodoro.GetSecond());
            pomodoro.Tick();
            Assert.AreEqual(1, pomodoro.GetMinute());
            Assert.AreEqual(59, pomodoro.GetSecond());

            for(int i = 0; i < 118; i++)
            {
                pomodoro.Tick();
            }

            bool onSwitchToBreakEventCalled = false;
            pomodoro.OnSwitchToBreak += new Action(() => onSwitchToBreakEventCalled = true);
            pomodoro.Tick();
            Assert.IsTrue(onSwitchToBreakEventCalled);

            Assert.IsFalse(pomodoro.CountdownEnd);
            Assert.AreEqual(1, pomodoro.GetMinute());
            Assert.AreEqual(0, pomodoro.GetSecond());

            bool onSwitchToTaskEventCalled = false;
            pomodoro.OnSwitchToTask += new Action(() => onSwitchToTaskEventCalled= true);

            for (int i = 0; i < 60; i++)
            {
                pomodoro.Tick();
            }
            Assert.IsTrue(onSwitchToTaskEventCalled);
            Assert.IsFalse(pomodoro.CountdownEnd);
            Assert.AreEqual(2, pomodoro.GetMinute());
            Assert.AreEqual(0, pomodoro.GetSecond());
        }
    }
}
