using Waveify.Core.Models;

namespace Waveify.Application.Repositiories
{
    public interface IUserRepository
    {
        Task Add(User user);
        Task<User> GetByEmail(string email);
    }
}