using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    public class ApplicationController : IApplicationController
    {
        private IPomodoroTimerServiceProvider serviceProvider;

        private IMainPresenter mainPresenter;
        private IConfigPresenter configPresenter;

        private List<ICommandable> presenters;

        public ApplicationController()
        {
            presenters = new List<ICommandable>();
        }

        public void Initialize(IPomodoroTimerServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;

            mainPresenter = serviceProvider.GetMainPresenter();
            presenters.Add(mainPresenter);

            configPresenter = serviceProvider.GetConfigPresenter();
            presenters.Add(configPresenter);

            configPresenter.ExecuteConfiguring();
        }

        public void Execute(ICommand command)
        {
            foreach(ICommandable presenter in presenters)
            {
                presenter.ProcessCommand(command);
            }
        }

        public void Run(App application)
        {
            switch(application)
            {
                case App.MainForm:
                    DisplayMainForm();
                    break;
                case App.Config:
                    DisplayConfigForm();
                    break;
            }
        }

        void DisplayMainForm()
        {
            mainPresenter.DisplayForm();
        }

        void DisplayConfigForm()
        {
            configPresenter.DisplayForm();
        }
    }
}
