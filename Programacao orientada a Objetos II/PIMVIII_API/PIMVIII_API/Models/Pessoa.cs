namespace PIMVIII_API.Models;

public class Pessoa
{
    public int Id { get; set; }

    public string Nome { get; set; }

    public long Cpf { get; set; }

    public Endereco Endereco { get; set; }

    public Telefone[] Telefones { get; set; }
}

