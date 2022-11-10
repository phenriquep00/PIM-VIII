using System;
using System.Collections.Generic;

namespace PIMVIII_API.Models;

public partial class Pessoa
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public long Cpf { get; set; }

    public int Endereco { get; set; }

    public virtual Endereco EnderecoNavigation { get; set; } = null!;

    public virtual PessoaTelefone? PessoaTelefone { get; set; }
}
