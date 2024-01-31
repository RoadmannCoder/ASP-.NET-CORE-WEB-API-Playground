using Dating_APP.Entities;
using Dating_APP.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Dating_APP.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetUserAsync() => await _context.Users.Include(p=>p.Photos).ToListAsync();

        public async Task<User> GetUserByIDAsync(int id) => await _context.Users.Include(p => p.Photos).SingleOrDefaultAsync(x=>x.Id == id);


        public async Task<User> GetUserByNameAsync(string name) => await _context.Users.Include(p => p.Photos).SingleOrDefaultAsync(x => x.Name == name);

        public async Task<bool> SaveAllAsync() => await _context.SaveChangesAsync() > 0;

        public void Update(User user) => _context.Entry(user).State = EntityState.Modified;
    }
}
