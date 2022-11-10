using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PIMVIII_API.Models;

namespace PARTECH_Postgresql.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        public PimviiiContext _context;
        public UserController(PimviiiContext context)
        {
            _context = context;
        }

        [HttpGet("GetDetails")]
        public async Task<List<Endereco>> GetDetails()
        {
            return await _context.Enderecos.ToListAsync();
        }
    }
}