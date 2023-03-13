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
			Device data = await new GetQueryHandler(_context).Handle(new GetQuery(id));
			type.Text = data.Type;
			name.Text = data.Name;
			code.Text = data.Code;
			department.Text = data.Department.Id.ToString();
			employee.Text = data.Employee.Id.ToString();
			tech.Text = data.Characteristics;
			nameinnet.Text = data.NameInNet;
			address.Text = data.IPAdress;
			provider.Text = data.Provider;
		}
		private async void Button_Click(object sender, RoutedEventArgs e)
		{
			int dep;
			int.TryParse(department.Text, out dep);
			int emp;
			int.TryParse(employee.Text, out emp);

			EditCommand command = new EditCommand(id)
			{
				Type = type.Text,
				Name = name.Text,
				Code = code.Text,
				DepartmentId = dep,
				Characteristics = tech.Text,
				EmployeeId = emp,
				NameInNet = nameinnet.Text,
				IPAdress = address.Text,
				Provider = provider.Text
			};
			EditCommandHandler handler = new EditCommandHandler(_context);
			await handler.Handle(command);
		}
	}
}
