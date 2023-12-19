namespace ASTL.Data.Entities
{
    public class Campanha
    {
        public int CampanhaID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }
    }
}
