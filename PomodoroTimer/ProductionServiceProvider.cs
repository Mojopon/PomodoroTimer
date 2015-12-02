using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    public class ProductionServiceProvider : ServiceProvider
    {
        protected override void PrepareConfigPresenter(IApplicationController applicationController)
        {
            var configForm = new ConfigForm();
            configPresenter = new ConfigPresenter(applicationController, configForm);
        }

        protected override void PrepareMainPresenter(IApplicationController applicationController)
        {
            var mainForm = new MainForm();
            mainPresenter = new MainPresenter(applicationController, mainForm);
        }
    }
}
