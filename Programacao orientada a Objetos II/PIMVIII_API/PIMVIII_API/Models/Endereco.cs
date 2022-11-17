namespace PIMVIII_API.Models;

public class Endereco
{
    public int Id { get; set; }

    public string Logradouro { get; set; }

    public int Numero { get; set; }

    public int Cep { get; set; }

    public string Bairro { get; set; }

    public string Cidade { get; set; }

    public string Estado { get; set; }

    public virtual ICollection<Pessoa> Pessoas { get; } = new List<Pessoa>();
}
