using CQRS.Query;
using Microsoft.EntityFrameworkCore;
using OfficeEquipment.Application.Interfaces;
using OfficeEquipment.Domain.Entities;

namespace OfficeEquipment.Application.Authentication.Login
{
	public class LoginQueryHandler : IQueryHandler<LoginQuery, int>
	{
		private readonly IContext _context;
		public LoginQueryHandler(IContext context)
		{
			_context = context;
		}

		public async Task<int> Handle(LoginQuery request)
		{
			List<User> users = await _context.Users.ToListAsync();

			User current = users.Where(f => f.Login.Equals(request.Login) & f.Password.Equals(request.Password)).FirstOrDefault() ?? new User() { Id = 0 };
			return current.Id;
		}
	}
}
