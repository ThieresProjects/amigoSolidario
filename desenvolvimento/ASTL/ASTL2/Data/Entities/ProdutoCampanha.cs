namespace ASTL.Data.Entities
{
    public class ProdutoCampanha
    {
        public int CampanhaID { get; set; }
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Perecivel { get; set; }
        public DateTime Validade { get; set; }
        public int Pontuacao { get; set; }
    }
}
