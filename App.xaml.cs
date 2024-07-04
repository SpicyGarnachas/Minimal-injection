using System.Windows;
using Unity;
using Minimal_injection.Services;
using Minimal_injection.ViewModel;
using Minimal_injection.Repository;

namespace Minimal_injection
{
    public partial class App : Application
    {
        private IUnityContainer? _container;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Configure Unity Container
            _container = new UnityContainer();
            ConfigureServices(_container);

            // Resolve the main window and show it
            var mainWindow = _container.Resolve<MainWindow>();
            mainWindow.Show();
        }

        private void ConfigureServices(IUnityContainer container)
        {
            // Register your services and repositories
            container.RegisterType<ICalculatorRepositpory, CalculatorRepositpory>();
            container.RegisterType<ICalculatorService, CalculatorService>();

            // Register ViewModel
            container.RegisterType<MainViewModel>();

            // Register other dependencies
            container.RegisterType<MainWindow>();
        }
    }
}
