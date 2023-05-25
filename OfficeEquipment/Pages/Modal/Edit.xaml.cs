using OfficeEquipment.Application.Device.Create;
using OfficeEquipment.Application.Device.Edit;
using OfficeEquipment.Application.Device.Get;
using OfficeEquipment.Application.Interfaces;
using OfficeEquipment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OfficeEquipment.Pages.Modal
{
	public partial class Edit : Window
	{
		private int id;
		private IContext _context;
		public Edit(int id, IContext context)
		{
			_context = context;
			InitializeComponent(); this.id = id;
			Load();

		}
		private async Task Load()
		{
			Order data = await new GetQueryHandler(_context).Handle(new GetQuery(id));
			type.Text = data.Type;
			name.Text = data.Name;
			code.Text = data.Code;
			@break.Text = data.Breaking;
			details.Text = data.Details;


		}
		private async void Button_Click(object sender, RoutedEventArgs e)
		{
			EditCommand command = new EditCommand(id)
			{
				Type = type.Text,
				Name = name.Text,
				Code = code.Text,
				Breaking = @break.Text,
				Details = details.Text,
				Id = id

			};
			EditCommandHandler handler = new EditCommandHandler(_context);
			await handler.Handle(command);
		}
	}
}
