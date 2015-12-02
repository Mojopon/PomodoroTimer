using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    public class ProductionServiceProvider : ServiceProvider
    {
        public ProductionServiceProvider(IApplicationController applicationController) : base(applicationController) { }

        public override IMainPresenter GetMainPresenter()
        {
            var mainForm = new MainForm();
            var mainPresenter = new MainPresenter(applicationController, mainForm);
            return mainPresenter;
        }

        public override IConfigPresenter GetConfigPresenter()
        {
            var configForm = new ConfigForm();
            var configPresenter = new ConfigPresenter(applicationController, configForm);
            return configPresenter;
        }
    }
}
