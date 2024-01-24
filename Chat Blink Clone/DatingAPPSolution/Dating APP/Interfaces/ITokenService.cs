using Dating_APP.Entities;

namespace Dating_APP.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
