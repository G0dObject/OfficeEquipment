using OfficeEquipment.Application.Device.Create;
using OfficeEquipment.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OfficeEquipment.Pages.Modal
{
	/// <summary>
	/// Interaction logic for Create.xaml
	/// </summary>
	public partial class Create : Window
	{
		private IContext _context;
		public Create(IContext context)
		{
			_context = context;
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{


			CreateCommand command = new CreateCommand()
			{
				Type = type.Text,
				Name = name.Text,
				Code = code.Text,
				Breaking = @break.Text,
				Details = details.Text,

			};
			Task<int> handle = new CreateCommandHandler(_context).Handle(command);
		}
	}
}
