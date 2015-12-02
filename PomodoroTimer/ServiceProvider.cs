using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    public abstract class ServiceProvider : IPomodoroTimerServiceProvider
    {
        protected IApplicationController applicationController;
        public ServiceProvider(IApplicationController target)
        {
            applicationController = target;
        }

        public abstract IMainPresenter GetMainPresenter();
        public abstract IConfigPresenter GetConfigPresenter();
    }
}
