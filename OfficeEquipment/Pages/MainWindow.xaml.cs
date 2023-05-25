using OfficeEquipment.Application.Device.Delete;
using OfficeEquipment.Application.Device.Get;
using OfficeEquipment.Domain.Entities;
using OfficeEquipment.Pages.Modal;
using OfficeEquipment.Pages.Pages;
using OfficeEquipment.Persistent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace OfficeEquipment
{
	public partial class MainWindow : Window
	{
		private readonly Context _context;
		private bool firstrun = true;
		private int _currentselect = 0;
		public MainWindow(Context context)
		{
			_context = context;

			InitializeComponent();
			DeviceGrid.AutoGenerateColumns = false;
			LoadData();

		}

		internal void LoadData()
		{
			DeviceGrid.ItemsSource = _context.Orders.ToList();
		}
		internal void LoadData(string search)
		{
			List<Order> all = _context.Orders.ToList();
			List<Order> items = all.Where(f => f.Name.ToLower().StartsWith(search.ToLower())).ToList();
			DeviceGrid.ItemsSource = items;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			LoadData(SearchField.Text);
		}

		private void Window_Closed(object sender, System.EventArgs e)
		{
			Environment.Exit(0);
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			Program.OpenWindow(typeof(OfficeEquipment.Pages.Authorization));
			this.Hide();
		}

		private void DeviceGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			//MessageBox.Show(sender.ToString());
			//SelectGrid.Items.Clear();
			DataGrid? g = sender as DataGrid;
			Order? device = g.CurrentItem as Order;
			if (device == null)
				return;
			_currentselect = device.Id;

			SelectGrid.Items.Clear();
			SelectGrid.Items.Add(device);
		}


		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			new Create(_context).ShowDialog();
			LoadData();
		}

		private void Button_Click_3(object sender, RoutedEventArgs e)
		{
			DeleteCommand command = new DeleteCommand() { Id = _currentselect };
			Task<int> handler = new DeleteCommandHandler(_context).Handle(command);
			SelectGrid.Items.Clear();
			LoadData();
		}

		private void Button_Click_4(object sender, RoutedEventArgs e)
		{
			int a = _currentselect;
			new Edit(_currentselect, _context).ShowDialog(); SelectGrid.Items.Clear();
			LoadData();



		}

		private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			Helper.Open(e);
		}
	}
}
