using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waveify.Persistence.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Waveify.Core.Models;

namespace Waveify.Persistence.Configurations
{
    //public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
    //{
    //    public void Configurate(EntityTypeBuilder<UserEntity> builder)
    //    {
    //        builder.HasKey(e => e.Id);
    //        builder.Property(b => b.UserName)
    //            .IsRequired();
    //            //.HasMaxLength(DrumKit.MAX_TITTLE_LENGHT);
    //        builder.Property(b => b.Email)
    //         .IsRequired();
    //        builder.Property(b => b.PasswordHash)
    //          .IsRequired();
    //    }
    //}
}
