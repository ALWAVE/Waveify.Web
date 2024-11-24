
using Waveify.Application.Auth;
using Waveify.Application.Repositiories;
using Waveify.Core.Models;
using Waveify.Interface.Auth;
namespace Waveify.Application.Services
{
    public class UserServices
    {
        private readonly IPasswordHash _passwordHasher;
        private readonly IUserRepository _usersRepository;
        private readonly IJwtProvider _jwtProvider;
        public UserServices(IPasswordHash passwordHash, IUserRepository userRepository, IJwtProvider jwtProvider) 
        {
            _passwordHasher = passwordHash;
            _usersRepository = userRepository;
            _jwtProvider = jwtProvider; 
        }
        public async Task Register(string userName, string email, string password)
        {
            var hashedPassword = _passwordHasher.Generate(password);
            var user = User.Create(Guid.NewGuid(), userName, hashedPassword, email);

            await _usersRepository.Add(user);
        }
        public async Task<string> Login(string email, string password)
        {
            var user = await _usersRepository.GetByEmail(email);
            var result = _passwordHasher.Verify(password, user.PasswordHash);
            if (result == false) {
                throw new Exception("Failed");
            }
            var token = _jwtProvider.GenerateToken(user);

            return token;
        }
    }
}
