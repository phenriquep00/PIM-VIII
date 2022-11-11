using System;
using System.Collections.Generic;

namespace PIMVIII_API.Models;

public  class Endereco
{
    public int Id { get; set; }

    public string Logradouro { get; set; } = null!;

    public int Numero { get; set; }

    public int Cep { get; set; }

    public string Bairro { get; set; } = null!;

    public string Cidade { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public virtual ICollection<Pessoa> Pessoas { get; } = new List<Pessoa>();
}
