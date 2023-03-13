using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OfficeEquipment.Application.Interfaces;
using OfficeEquipment.Persistent;
using System.Net;
using System.Windows;

namespace OfficeEquipment
{
	public class App : System.Windows.Application
	{
		private readonly IHost _host;
		public App(IHost host)
		{
			_host = host;

		}
		protected override void OnStartup(StartupEventArgs e)
		{
			Program.OpenWindow(typeof(Pages.Authorization));
			base.OnStartup(e);
		}
	}
}
