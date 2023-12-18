namespace ASTL.Models
{
    public class CampanhaScore
    {
        public int ScoreID { get; set; }
        public int CampanhaID { get; set; }
        public int ProdutoID { get; set; }
        public Produto Produto { get; set; }
        public int Pontuacao { get; set; }
    }
}
