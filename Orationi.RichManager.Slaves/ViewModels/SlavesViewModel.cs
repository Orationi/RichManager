using System;
using Prism.Mvvm;

namespace Orationi.RichManager.Slaves.ViewModels
{
	/// <summary>
	/// Slave item view model.
	/// </summary>
	public class SlavesViewModel : BindableBase
	{
		/// <summary>
		/// Identifier of Slave.
		/// </summary>
		public Guid Id { get; set; }

		/// <summary>
		/// Slave name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Slave description.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Ip address of slave.
		/// </summary>
		public string Address { get; set; }

		/// <summary>
		/// Date and Time of last slave activity.
		/// </summary>
		public DateTime? LastActivity { get; set; }
	}
}
