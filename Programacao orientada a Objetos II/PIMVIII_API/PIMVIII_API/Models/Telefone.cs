using System;
using System.Collections.Generic;

namespace PIMVIII_API.Models;

public partial class Telefone
{
    public int Id { get; set; }

    public int Numero { get; set; }

    public int Ddd { get; set; }

    public int Tipo { get; set; }

    public virtual ICollection<PessoaTelefone> PessoaTelefones { get; } = new List<PessoaTelefone>();

    public virtual TelefoneTipo TipoNavigation { get; set; } = null!;
}
