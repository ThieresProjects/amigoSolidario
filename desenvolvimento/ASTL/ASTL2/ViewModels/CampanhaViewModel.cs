using ASTL.Data.Entities;

namespace ASTL2.ViewModels
{
    public class CampanhaViewModel
    {
        public int CampanhaID { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public IEnumerable<UsuarioCampanhaViewModel>? usuarios { get; set; }
        public IEnumerable<ProdutoCampanha>? Produtos { get; set; }
        public IEnumerable<CampanhaPremio>? Premios { get; set; }
        public IEnumerable<CampanhaGrupo>? Grupos { get; set; }
    }
}
