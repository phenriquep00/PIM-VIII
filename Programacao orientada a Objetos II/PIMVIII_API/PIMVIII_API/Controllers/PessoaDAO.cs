using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PIMVIII_API.Models;

namespace PIMVIII_API.Controllers
{
    [Route("api/[controller]")]
    public class PessoaDAO : Controller
    {
        public PimviiiContext _context;
        public PessoaDAO(PimviiiContext context)
        {
            _context = context;
        }

        [HttpDelete("Exclua/{p}")]
        public async IAsyncEnumerable<bool> Exclua(Pessoa p)
        {
            // Busca pela pessoa no database
            Pessoa pessoaParaDeletar = await Consulte(p.Id);

            //Checa se a pessoa existe no banco
            if (pessoaParaDeletar == null)
            {
                throw new Exception($"Usuário com cpf:{p.Id} não foi encontrado.");
            }

            _context.Pessoas.Remove(pessoaParaDeletar);
            await _context.SaveChangesAsync();

            yield return true;
        }

        [HttpPost("Insira/{p}")]
        public async IAsyncEnumerable<bool> Insira(Pessoa p)
        {
            // Insere novo objeto Pessoa no banco de dados
            await _context.Pessoas.AddAsync(p);
            await _context.SaveChangesAsync();
            yield return true;
        }

        [HttpPut("Altere/{p}")]
        public async IAsyncEnumerable<bool> Altere(Pessoa p)
        {
            // Busca pela pessoa no database
            Pessoa pessoaParaAtualizar = await Consulte(p.Id);

            //Checa se a pessoa existe no banco
            if(pessoaParaAtualizar == null)
            {
                throw new Exception($"Usuário com cpf:{p.Id} não foi encontrado.");
            }

            // Modifica as propriedades do objeto, atualizando para as propriedades dadas no parametro
            pessoaParaAtualizar.Nome = p.Nome;
            pessoaParaAtualizar.Cpf = p.Cpf;
            pessoaParaAtualizar.Endereco = p.Endereco;
            pessoaParaAtualizar.PessoaTelefone = p.PessoaTelefone;

            // confirma modificações e salva no banco de dados
            _context.Pessoas.Update(pessoaParaAtualizar);
            await _context.SaveChangesAsync();

            yield return true;
        }

        [HttpGet("Consulte/{cpf}")]
        public async Task<Pessoa> Consulte(long cpf)
        {
            // Busca por um objeto Pessoa no banco de dados, baseado em um cpf dado como parametro
            return await _context.Pessoas.FirstOrDefaultAsync(x => x.Cpf == cpf);
        }


    }
}
