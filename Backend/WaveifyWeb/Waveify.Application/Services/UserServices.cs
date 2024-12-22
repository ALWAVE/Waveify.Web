
using Waveify.Application.Auth;
using Waveify.Application.Interface.Repositiories;
using Waveify.Core.Models;
using Waveify.Interface.Auth;
namespace Waveify.Application.Services
{
    public class UserServices
    {
        private readonly IPasswordHash _passwordHasher;
        private readonly IUserRepository _usersRepository;
        private readonly IJwtProvider _jwtProvider;
        public UserServices(
            IPasswordHash passwordHash, 
            IUserRepository userRepository, 
            IJwtProvider jwtProvider) 
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
            if (user == null)
            {
                throw new InvalidOperationException("User  not found.");
            }

            var result = _passwordHasher.Verify(password, user.PasswordHash);
            if (!result)
            {
                throw new InvalidOperationException("Invalid password.");
            }

            var token = _jwtProvider.GenerateToken(user);
            return token;
        }
    }
}
