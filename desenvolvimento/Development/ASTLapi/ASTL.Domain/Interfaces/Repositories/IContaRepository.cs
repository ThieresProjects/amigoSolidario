namespace ASTL.Domain.Interfaces.Repositories
{
    public interface IContaRepository
    {
        bool Verify(string usuario, string password);
    }
}
