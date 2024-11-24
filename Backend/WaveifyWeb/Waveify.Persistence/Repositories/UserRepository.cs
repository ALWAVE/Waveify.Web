using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waveify.Core.Models;
using Waveify.Application.Repositiories;
using System.IO.MemoryMappedFiles;
using System.Globalization;
using Waveify.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
namespace Waveify.Persistence.Repositiories
{
    public class UserRepository : IUserRepository
    {
        private readonly WaveifyDbContext _context;
        private readonly IMapper _mapper;
        public UserRepository(WaveifyDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task Add(User user)
        {
            var userEntity = new UserEntity()
            {
                Id = user.Id,
                UserName = user.UserName,
                PasswordHash = user.PasswordHash,
                Email = user.Email
            };

            //await _context.Users.AddAsync(userEntity);
            await _context.SaveChangesAsync();

        }
        public async Task<User> GetByEmail(string email)
        {
            var userEntity = await _context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Email == email) ?? throw new Exception();
            return _mapper.Map<User>(userEntity);
        }
    }
}
