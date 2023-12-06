namespace ASTL.Domain.Entities;
public class LogDoacao
{
    public int DoacaoId { get; set; }

    public int RemetenteId { get; set;}
    public Conta Remetente { get; set;}

    public int DestinatarioId { get; set;}
    public Conta Destinatario { get; set;}

    public int ObjetoId { get; set;}
    public Objeto Objeto { get; set;}

    public bool Enviado { get; set; }
    public string Descricao { get; set; }
    public string TipoDoacao { get; set; }
    public DateTime Data { get; set; }
}
