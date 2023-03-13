using Microsoft.EntityFrameworkCore;
using OfficeEquipment.Application.Authentication.Login;
using OfficeEquipment.Application.Authentication.Register;
using OfficeEquipment.Application.Interfaces;
using OfficeEquipment.Domain.Entities;
using OfficeEquipment.Model;
using System;
using System.Windows;
using System.Windows.Input;

namespace OfficeEquipment.Pages
{
	public partial class Authorization : Window
	{
		private bool _isRegister = true;
		private readonly AuthorizationModel command;
		private IContext _context;
		private int _userid;
		private Role _role;
		public Authorization(IContext context)
		{
			_context = context;
			InitializeComponent();
			command = new AuthorizationModel();
			this.DataContext = command;
		}

		private void Window_KeyDown(object sender, KeyEventArgs e)
		{

		}

		private void SwapButton_Click(object sender, RoutedEventArgs e)
		{

			if (_isRegister)
			{
				Login.Visibility = Visibility.Visible;
				Register.Visibility = Visibility.Hidden;

				SwapButton.Content = "Регистрация";
				_isRegister = false;
			}
			else
			{
				Login.Visibility = Visibility.Hidden;
				Register.Visibility = Visibility.Visible;

				SwapButton.Content = "Войти";
				_isRegister = true;
			}

		}

		//ахтунг async void ахтунг
		private async void RegistrationButton(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrEmpty(command.Error))
			{
				try
				{
					RegisterCommand registerCommand = new(RUsername.Text, RPassword.Text, new Role() { Name = "User" });
					RegisterCommandHandler handler = new(_context);

					if (await _context.Users.FirstOrDefaultAsync(u => u.Login == registerCommand.Login) != null)
					{
						_ = MessageBox.Show("Такой пользователь уже зарегестрирован");
						return;
					}

					_userid = await handler.Handle(registerCommand);

					_role = await _context.Roles.FirstOrDefaultAsync(r => r.Id == _userid);
					Ok();
				}
				catch (Exception)
				{
					throw;
				}
			}

		}
		private async void LoginButton(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrEmpty(command.Error))
			{
				try
				{
					LoginQuery loginQuery = new(LUsername.Text, LPassword.Text);
					LoginQueryHandler handler = new(_context);

					int result = await handler.Handle(loginQuery);
					_userid = result;
					User? user = await _context.Users.Include(f => f.Role).FirstOrDefaultAsync(f => f.Id == _userid);
					_role = await _context.Roles.FirstAsync(f => f.Id == user.Role.Id) ?? throw new NullReferenceException();
					Ok();
				}
				catch (Exception ex)
				{
					_ = MessageBox.Show("Что-то не так, попробуйте снова", ex.Message);
				}
			}
		}
		private void Ok()
		{
			Program.OpenWindow(typeof(MainWindow));
			this.Hide();
		}
	}
}
