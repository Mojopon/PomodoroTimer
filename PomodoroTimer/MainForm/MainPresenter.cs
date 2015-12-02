using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTimer
{
    public class MainPresenter : IMainPresenter
    {
        private Pomodoro pomodoro;
        private IMainForm mainform;
        private IApplicationController applicationController;
        public MainPresenter(IApplicationController applicationController, IMainForm mainform)
        {
            this.applicationController = applicationController;
            this.mainform = mainform;
            pomodoro = new Pomodoro();

            mainform.OnTimerStart += OnStartEvent;
            mainform.OnTimerTick += OnTickEvent;
            mainform.OnConfigOpen += OnConfigOpenEvent;
        }

        public void Run()
        {
            mainform.Run();
        }

        private void DrawTime()
        {
            mainform.DrawTime(pomodoro.GetMinute(), pomodoro.GetSecond());
        }

        private void OnStartEvent()
        {
            DrawTime();
        }

        private void OnTickEvent()
        {
            pomodoro.Tick();
            DrawTime();
            if (pomodoro.CountdownEnd)
            {
                mainform.TimerEnd();
            }
        }

        private void OnConfigOpenEvent()
        {
            applicationController.Run(App.Config);
        }

        public void ProcessCommand(ICommand command)
        {
            pomodoro.ProcessCommand(command);
        }
    }
}
