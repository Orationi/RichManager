using System.Windows;

namespace Orationi.RichManager
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			Bootstrapper bs = new Bootstrapper();
			bs.Run();
		}
	}
}
