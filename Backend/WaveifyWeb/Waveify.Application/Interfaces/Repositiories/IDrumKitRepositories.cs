using Waveify.Core.Models;

namespace Waveify.Application.Interface.Repositiories
{
    public interface IDrumKitRepositories
    {
        Task<Guid> Create(DrumKit drumKit);
        Task<Guid> Delete(Guid id);
        Task<List<DrumKit>> Get();
        Task<Guid> Update(Guid id, string tittle, string desc, string url, decimal price);
    }
}