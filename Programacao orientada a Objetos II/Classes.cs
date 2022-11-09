using System.Security.Cryptography;

namespace WebApplication1.Models
{
    public class Pessoa
    {
        protected int id { get; set; }
        public string nome { get; set; }
        public long cpf { get; set; }
        public Endereco endereco { get; set; }
        public Telefone[] telefones { get; set; }

    }

    public class Endereco
    {
        protected int id { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }
        public int cep { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
    }

    public class Telefone
    {
        protected int id { get; set; }
        public int numero { get; set; }
        public int ddd { get; set; }
        public TipoTelefone tipo { get; set; }
    }

    public class TipoTelefone
    {
        protected int id { get; set; }
        public string tipo { get; set; }
    }

    public class PessoaDAO
    {
        public bool Exclua(Pessoa p)
        {
            Console.WriteLine(p.nome);

            return true;
        }

        public bool Insira(Pessoa p)
        {
            Console.WriteLine(p.nome);

            return true;
        }

        public bool Altere(Pessoa p)
        {
            Console.WriteLine(p.nome);

            return true;
        }

        public Pessoa Consulte(long cpf)
        {
            Pessoa p1 = new Pessoa();

            p1.cpf = cpf;

            return p1;
        }
    }

    public class MainClass
    {
        public static void Main()
        {
            Pessoa p1 = new Pessoa();
            Endereco e1 = new Endereco();


            p1.nome = "Pedro";

            p1.endereco = e1;

            e1.logradouro = "rua blob";

            Console.WriteLine("pessoas: {0}", p1.endereco.logradouro);
        }
    }
}
