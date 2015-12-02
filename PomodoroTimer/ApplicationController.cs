using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    public class ApplicationController : IApplicationController
    {
        private MainPresenter mainPresenter;
        private ConfigPresenter configPresenter;

        private List<ICommandable> commandables = new List<ICommandable>();

        public ApplicationController()
        {
            var mainForm = new MainForm();
            mainPresenter = new MainPresenter(this, mainForm);
            commandables.Add(mainPresenter);

            var configForm = new ConfigForm();
            configPresenter = new ConfigPresenter(this, configForm);
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
                    RunMainForm();
                    break;
                case App.Config:
                    RunConfigForm();
                    break;
            }
        }

        void RunMainForm()
        {
            mainPresenter.Run();
        }

        void RunConfigForm()
        {
            configPresenter.Run();
        }
    }
}
