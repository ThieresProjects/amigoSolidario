namespace ASTL.Domain.Interfaces.Services
{
    public interface IContaService
    {
        Task<bool> VerifyAsync(string usuario, string password);        
    }
}
