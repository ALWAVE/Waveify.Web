namespace Waveify.API.Contracts
{
    public record DrumKitResponse(Guid id,
        string tittle, 
        string description,
        string url, 
        decimal price);

}
