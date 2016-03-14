using System.Collections.Generic;
using System.Collections.ObjectModel;
using Orationi.CommunicationCore.Model;
using Prism.Mvvm;

namespace Orationi.RichManager.Slaves.ViewModels
{
	public class SlavesViewModel : BindableBase
	{
		/// <summary>
		/// List of existing slaves.
		/// </summary>
		public ObservableCollection<SlaveViewModel> Slaves { get; set; }

		public SlavesViewModel()
		{

		}

		public SlavesViewModel(IEnumerable<OrationiSlaveItem> slaves)
		{
			Slaves = new ObservableCollection<SlaveViewModel>();
			foreach (OrationiSlaveItem orationiSlaveItem in slaves)
			{
				SlaveViewModel slave = new SlaveViewModel(orationiSlaveItem);
				Slaves.Add(slave);
			}
		}
	}
}
