using Waveify.Core.Models;

namespace Waveify.Application.Interface.Repositiories
{
    public interface IUserRepository
    {
        Task Add(User user);
        Task<User> GetByEmail(string email);
    }
}