namespace ASTL.Models
{
    public class Conta
    {
        public int ContaID { get; set; }
        public string? Img { get; set; }
        public string Usuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }
    }
}
