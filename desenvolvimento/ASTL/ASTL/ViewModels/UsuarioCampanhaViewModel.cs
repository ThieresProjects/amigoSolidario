using ASTL.Data.Entities;
using ASTL.Data.Repositories;

namespace ASTL.ViewModels
{
    public class UsuarioCampanhaViewModel
    {
        public int CampanhaID { get; set; }
        public int ContaID { get; set; }
        public int GrupoID { get; set; }
        public bool Admin { get; set; }
        public decimal Score { get; set; }
        public Conta Usuario { get; set; }
        public CampanhaGrupo Grupo { get; set; }

        public IEnumerable<UsuarioScore> Scores { get; set; }
    }
}
