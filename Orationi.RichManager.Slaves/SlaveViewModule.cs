using Orationi.RichManager.Slaves.Views;
using Prism.Modularity;
using Prism.Regions;

namespace Orationi.RichManager.Slaves
{
	public class SlaveViewModule : IModule
	{
		IRegionManager _regionManager;

		public SlaveViewModule(IRegionManager regionManager)
		{
			_regionManager = regionManager;
		}

		public void Initialize()
		{
			_regionManager.RegisterViewWithRegion("MainRegion", typeof(SlavesView));
		}
	}
}
