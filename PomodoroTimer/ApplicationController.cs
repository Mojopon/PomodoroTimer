using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    public class ApplicationController : IApplicationController
    {
        private IMainPresenter mainPresenter;
        private IConfigPresenter configPresenter;

        private List<ICommandable> commandables = new List<ICommandable>();

        public ApplicationController(IServiceProvider serviceProvider)
        {
            mainPresenter = serviceProvider.GetMainPresenter(this);
            commandables.Add(mainPresenter);

            configPresenter = serviceProvider.GetConfigPresenter(this);
            configPresenter.ExecuteConfiguring();
        }

        public void Execute(ICommand command)
        {
            foreach(ICommandable commandable in commandables)
            {
                commandable.ProcessCommand(command);
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
