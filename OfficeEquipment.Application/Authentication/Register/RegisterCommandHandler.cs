using CQRS.Command;
using Microsoft.EntityFrameworkCore;
using OfficeEquipment.Application.Interfaces;
using OfficeEquipment.Domain.Entities;

namespace OfficeEquipment.Application.Authentication.Register
{
	public class RegisterCommandHandler : ICommandHandler<RegisterCommand, int>
	{
		private readonly IContext _context;
		private string _defaultRole = "User";
		public RegisterCommandHandler(IContext context)
		{
			_context = context;
		}

		public async Task<int> Handle(RegisterCommand request)
		{
			User current = new()
			{
				Login = request!.Login,
				Password = request!.Password,
				Role = await GetDefaultRole()
			};

			Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<User> result = await _context.Users.AddAsync(current);
			await _context.SaveChangesAsync(new CancellationToken());
			return result.Entity.Id;
		}


		private async Task<Role> GetDefaultRole()
		{
			if (await _context!.Roles!.FirstOrDefaultAsync(f => f.Name == _defaultRole) == null)
			{
				_ = await _context!.Roles!.AddAsync(new Role() { Name = _defaultRole });
				_ = await _context.SaveChangesAsync(new CancellationToken());
			}
			Role result = await _context!.Roles!.FirstAsync(f => f.Name == _defaultRole);
			return result;
		}
	}
}
