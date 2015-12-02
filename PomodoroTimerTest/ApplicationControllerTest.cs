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
    public class ApplicationControllerTest
    {
        private ApplicationController applicationController;
        private IPomodoroTimerServiceProvider serviceProvider;

        private IMainPresenter mainPresenter;
        private IConfigPresenter configPresenter;

        [SetUp]
        public void Initialize()
        {
            CreateApplicationController();
            SetupTestServices();
            InitializeApplicationController();
        }

        void CreateApplicationController()
        {
            applicationController = new ApplicationController();
        }

        void SetupTestServices()
        {

            mainPresenter = Substitute.For<IMainPresenter>();
            configPresenter = Substitute.For<IConfigPresenter>();

            serviceProvider = new TestServiceProvider(applicationController, mainPresenter, configPresenter);
        }

        void InitializeApplicationController()
        {
            applicationController.Initialize(serviceProvider);
        }

        [Test]
        public void ShouldDisplayMainForm()
        {
            applicationController.Run(App.MainForm);
            mainPresenter.Received().DisplayForm();
        }

        [Test]
        public void ShouldDisplayConfigForm()
        {
            applicationController.Run(App.Config);
            configPresenter.Received().DisplayForm();
        }

        [Test]
        public void ShouldExecuteCommand()
        {
            ICommand command = Substitute.For<ICommand>();
            applicationController.Execute(command);
            mainPresenter.Received().ProcessCommand(command);
            configPresenter.Received().ProcessCommand(command);
        }
    }
}
