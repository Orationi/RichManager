using Prism.Mvvm;

namespace Orationi.RichManager.Slaves.ViewModels
{
	public class SlavesViewModel : BindableBase
	{
		private string _title = "Slaves";

		public string Title
		{
			get { return _title; }
			set { SetProperty(ref _title, value); }
		}
	}
}
