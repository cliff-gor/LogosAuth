using LogosAuth.Entities;
using LogosAuth.Models;
using System.Threading.Tasks;

namespace LogosAuth.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDto request);
        Task<string?> LoginAsync(UserDto request);
    }
}
