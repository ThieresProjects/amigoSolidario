namespace ASTL.Data.Entities
{
    public class CampanhaPremio
    {
        public int PremioID { get; set; }
        public int CampanhaID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Ordem { get; set; }
    }
}
