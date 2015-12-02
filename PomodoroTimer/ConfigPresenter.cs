using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    public class ConfigPresenter : IConfigPresenter
    {
        private IApplicationController applicationController;
        private ConfigManager manager;
        private IConfigForm form;

        public ConfigPresenter(IApplicationController applicationController, IConfigForm form)
        {
            this.applicationController = applicationController;
            this.form = form;

            manager = new ConfigManager();
        }

        public void DisplayForm()
        {
            ExecuteConfiguring();
            form.DisplayForm();
        }

        public void ExecuteConfiguring()
        {
            int taskTime = form.GetTaskTime();
            int breakTime = form.GetBreakTime();
            int repeatTime = form.GetRepeatTime();
            int longBreakTime = form.GetLongBreakTime();
            manager.ChangePomodoroConfig(taskTime, breakTime, repeatTime, longBreakTime);

            var config = manager.GetConfig();
            var command = new ChangeConfigCommand(config);
            applicationController.Execute(command);
        }

        public void ProcessCommand(ICommand command)
        {
            throw new NotImplementedException();
        }
    }
}
