using Minimal_injection.Repository;
using Minimal_injection.Services;
using System.Configuration;
using System.Data;
using System.Windows;
using Unity;

namespace Minimal_injection
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IUnityContainer _container;

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
            //container.RegisterType<ICalculatorService, CalculatorService>();

            // Register other dependencies
            container.RegisterType<MainWindow>();
        }
    }

}
