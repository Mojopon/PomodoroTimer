using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NSubstitute;
using PomodoroTimer;

namespace PomodoroTimerTest
{
    [TestFixture]
    public class CommandTest
    {
        [Test]
        public void ShouldConfigureTarget()
        {
            var configManager = new ConfigManager();
            configManager.ChangePomodoroConfig(10, 5, 2, 7);
            var config = configManager.GetConfig();
            var command = new ChangeConfigCommand(config);

            var pomodoro = Substitute.For<IPomodoro>();
            command.Execute(pomodoro);

            pomodoro.Received().Configure(config);
        }
    }
}
