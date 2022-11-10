using System;
using System.Collections.Generic;

namespace PIMVIII_API.Models;

public partial class PessoaTelefone
{
    public int IdPessoa { get; set; }

    public int IdTelefone { get; set; }

    public virtual Pessoa IdPessoaNavigation { get; set; } = null!;

    public virtual Telefone IdTelefoneNavigation { get; set; } = null!;
}
