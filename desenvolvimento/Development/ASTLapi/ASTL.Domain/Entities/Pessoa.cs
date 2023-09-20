namespace ASTL.Domain.Entities;
public class Pessoa
{
    public int PessoaId { get; set; }
    public string Nome { get; set;}
    public string CPF { get; set; }
    public Endereco Endereco { get; set; }
    public DateTime DataNascimento { get; set; }
}
