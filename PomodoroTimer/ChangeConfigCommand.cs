using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    public class ChangeConfigCommand : ICommand
    {
        private IConfig config;
        public ChangeConfigCommand(IConfig config)
        {
            this.config = config;
        }

        public void Execute(ICommandable target)
        {
            var configurable = target as IConfigurable;
            if(configurable != null)
            {
                ConfigureTarget(configurable);
            }
        }

        void ConfigureTarget(IConfigurable target)
        {
            target.Configure(config);
        }
    }
}
