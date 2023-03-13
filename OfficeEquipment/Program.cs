using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OfficeEquipment.Application.Interfaces;
using OfficeEquipment.Domain.Entities;
using OfficeEquipment.Pages;
using OfficeEquipment.Persistent;
using System;
using System.Threading;
using System.Windows;

namespace OfficeEquipment
{
	internal class Program
	{
		private static IHost? host;
		[STAThread]
		public static void Main()
		{
			host = Host.CreateDefaultBuilder()
			   .ConfigureServices(services =>
			   {
				   _ = services.AddDbContext<IContext, Context>();
				   _ = services.AddSingleton<App>();
				   _ = services.AddSingleton<MainWindow>();
				   _ = services.AddSingleton<Authorization>();
			   })
			   .Build();

			App app = host.Services.GetRequiredService<App>();
			IContext db = host.Services.GetRequiredService<IContext>();


			_ = app.Run();

		}

		internal static void OpenWindow(Type type)
		{
			try
			{
				Window? window = host.Services.GetRequiredService(type) as Window;
				if (window.GetType() == typeof(MainWindow))
				{

				}
				window.Show();
			}
			catch (Exception ex)
			{
				_ = MessageBox.Show(ex.ToString());
			}
		}
	}
}
