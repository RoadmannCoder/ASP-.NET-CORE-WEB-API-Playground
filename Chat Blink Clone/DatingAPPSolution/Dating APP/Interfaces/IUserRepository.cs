using Dating_APP.Entities;

namespace Dating_APP.Interfaces
{
    public interface IUserRepository
    {
        void Update(User user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<User>> GetUserAsync();
        Task<User> GetUserByIDAsync(int id);
        Task<User> GetUserByNameAsync(string name);

    }
}
