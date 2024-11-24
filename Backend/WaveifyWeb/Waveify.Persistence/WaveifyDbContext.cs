using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Waveify.Core.Models;
using Waveify.Persistence.Entities;
namespace Waveify.Persistence
{
    public class WaveifyDbContext : DbContext
    {
        public WaveifyDbContext(DbContextOptions<WaveifyDbContext> options) : base(options) 
        {

        }
        public DbSet<DrumKitEntity> DrumKits { get; set; }
        public DbSet<UserEntity> Users { get; set; }
    }
}
