using System;
using Orationi.CommunicationCore.Model;
using Prism.Mvvm;

namespace Orationi.RichManager.Slaves.ViewModels
{
	/// <summary>
	/// Slave item view model.
	/// </summary>
	public class SlaveViewModel : BindableBase
	{
		/// <summary>
		/// Identifier of Slave.
		/// </summary>
		public Guid Id => _slaveItem.Id;

		/// <summary>
		/// Slave name.
		/// </summary>
		public string Name
		{
			get { return _slaveItem.Name; }
			set
			{
				if (_slaveItem.Name.Equals(value))
					return;

				_slaveItem.Name = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Slave description.
		/// </summary>
		public string Description
		{
			get { return _slaveItem.Description; }
			set
			{
				if (_slaveItem.Description.Equals(value))
					return;

				_slaveItem.Description = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Ip address of slave.
		/// </summary>
		public string Address => _slaveItem.Address;

		/// <summary>
		/// Date and Time of last slave activity.
		/// </summary>
		public DateTime? LastActivity => _slaveItem.LastActivity;

		private readonly OrationiSlaveItem _slaveItem;

		public SlaveViewModel()
		{

		}

		public SlaveViewModel(OrationiSlaveItem slaveItem)
		{
			_slaveItem = slaveItem;
		}
	}
}
