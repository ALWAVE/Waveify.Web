using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Waveify.Core.Models;
using Waveify.Persistence.Entities;
namespace Waveify.Persistence
{
    public class DataBaseMapping : Profile
    {
        public DataBaseMapping()
        {
            // Настройка маппинга между сущностями и моделями
            CreateMap<UserEntity, User>(); // Пример маппинга для UserEntity и User
                                           // Добавьте здесь другие маппинги по мере необходимости
        }
    }
}
