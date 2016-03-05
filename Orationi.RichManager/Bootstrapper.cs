using System.Windows;
using Microsoft.Practices.Unity;
using Orationi.RichManager.Slaves;
using Orationi.RichManager.Views;
using Prism.Modularity;
using Prism.Unity;

namespace Orationi.RichManager
{
	public class Bootstrapper : UnityBootstrapper
	{
		protected override DependencyObject CreateShell()
		{
			return Container.Resolve<MainWindow>();
		}

		protected override void InitializeShell()
		{
			Application.Current.MainWindow.Show();
		}

		protected override void ConfigureModuleCatalog()
		{
			ModuleCatalog catalog = (ModuleCatalog)ModuleCatalog;
			catalog.AddModule(typeof(SlaveViewModule));
		}
	}
}
