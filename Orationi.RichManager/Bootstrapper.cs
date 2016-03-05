using System;
using Prism.Unity;
using System.Windows;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Orationi.RichManager.Views;

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
			throw new NotImplementedException();
		}
	}
}
