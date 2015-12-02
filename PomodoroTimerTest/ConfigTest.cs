using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PomodoroTimer;
using NSubstitute;

namespace PomodoroTimerTest
{
    [TestFixture]
    public class ConfigTest
    {
        ConfigManager manager;

        [SetUp]
        public void CreateConfigManager()
        {
            manager = new ConfigManager();
        }

        [Test]
        public void ShouldConfigureConfigurable()
        {
            var configurableMock = Substitute.For<IConfigurable>();
            IConfig config = manager.GetConfig();
            configurableMock.Configure(config);
        }

        [Test]
        public void ShouldConfigurePomodoroTimer()
        {
            var pomodoroMock = Substitute.For<IConfigurablePomodoro>();
            int taskTimeResult = -1;
            int breakTimeResult = -1;
            int repeatTimeResult = -1;
            int longBreakTimeResult = -1;
            pomodoroMock.Configure(Arg.Do<IPomodoroConfig>(x => {
                taskTimeResult = x.TaskTime;
                breakTimeResult = x.BreakTime;
                repeatTimeResult = x.RepeatTime;
                longBreakTimeResult = x.LongBreakTime;
            })); 

            manager.ChangePomodoroConfig(30, 10, 2, 20);

            IConfig config = manager.GetConfig();
            config.ConfigurePomodoro(pomodoroMock);

            pomodoroMock.Received().Configure(Arg.Any<IPomodoroConfig>());
            Assert.AreEqual(taskTimeResult, 30);
            Assert.AreEqual(breakTimeResult, 10);
            Assert.AreEqual(repeatTimeResult, 2);
            Assert.AreEqual(longBreakTimeResult, 20);
        }
    }
}
