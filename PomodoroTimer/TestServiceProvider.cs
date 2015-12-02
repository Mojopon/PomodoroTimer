using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    public class TestServiceProvider : ServiceProvider
    {
        private IMainPresenter mainPresenter;
        private IConfigPresenter configPresenter;

        public TestServiceProvider(IApplicationController applicationController, IMainPresenter mainPresenter, IConfigPresenter configPresenter) : base(applicationController)
        {
            this.mainPresenter = mainPresenter;
            this.configPresenter = configPresenter;
        }

        public override IMainPresenter GetMainPresenter()
        {
            return mainPresenter;
        }

        public override IConfigPresenter GetConfigPresenter()
        {
            return configPresenter;
        }
    }
}
