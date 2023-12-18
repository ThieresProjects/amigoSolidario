using ASTL.Data.Entities;

namespace ASTL.Data.Repositories
{
    public class ContaRepository : RepositorioBase<Conta>
    {
        public int Verify(string user, string password)
        {
            var ent = ListarTodos().Where(x => x.Email == user &&
                                                  BCrypt.Net.BCrypt.Verify(password, x.Senha)
                                     ).ToList();
            return ent.FirstOrDefault().ContaID;
        }

        public async Task<int> VerifyAsync(string user, string password)
        {
            var ent = (await ListarTodosAsync()).Where(x => x.Email == user &&
                                                            BCrypt.Net.BCrypt.Verify(password, x.Senha)
                                                      ).ToList();
            return ent.FirstOrDefault().ContaID;
        }

        public bool Register(Conta conta)
        {
            var ent = ListarTodos().Where(x => x.Email == conta.Email);
            if(ent.Count() == 0)
            {
                Adicionar(new Conta()
                {
                    Usuario = conta.Usuario,
                    Email = conta.Email,
                    Senha = BCrypt.Net.BCrypt.HashPassword(conta.Senha),
                    ContaID = ListarTodos().Count() + 1,
                    CriadoEm = DateTime.Now,
                    AtualizadoEm = DateTime.Now
                });
                return true;
            }
            return false;
        }
    }
}
