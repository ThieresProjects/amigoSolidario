namespace ASTL.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Perecivel { get; set; }
        public DateTime Validade { get; set; }
    }
}
