using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    public abstract class ServiceProvider : IServiceProvider
    {
        protected IMainPresenter mainPresenter;
        protected IConfigPresenter configPresenter;

        public ServiceProvider() { }

        protected abstract void PrepareConfigPresenter(IApplicationController applicationController);
        protected abstract void PrepareMainPresenter(IApplicationController applicationController);

        public IMainPresenter GetMainPresenter(IApplicationController applicationController)
        {
            if (mainPresenter == null)
            {
                PrepareMainPresenter(applicationController);
            }
            return mainPresenter;
        }

        public IConfigPresenter GetConfigPresenter(IApplicationController applicationController)
        {
            if (configPresenter == null)
            {
                PrepareConfigPresenter(applicationController);
            }
            return configPresenter;
        }
    }
}
