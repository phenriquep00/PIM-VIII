namespace PIMVIII_API.Models;

public class Telefone
{
    public int Id { get; set; }

    public int Numero { get; set; }

    public int Ddd { get; set; }

    public TelefoneTipo Tipo { get; set; }

}
