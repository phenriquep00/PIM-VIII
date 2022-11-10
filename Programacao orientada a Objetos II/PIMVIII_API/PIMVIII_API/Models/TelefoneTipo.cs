using System;
using System.Collections.Generic;

namespace PIMVIII_API.Models;

public partial class TelefoneTipo
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public virtual ICollection<Telefone> Telefones { get; } = new List<Telefone>();
}
