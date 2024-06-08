using CrudAPI.Data;
using CrudAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks; 

namespace CrudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatosController : ControllerBase
    {
        private readonly DataContext _context;

        public ContatosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Contatos>>> GetAllContato()
        {
            var contatos = await _context.Contatos.ToListAsync();

            return Ok(contatos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Contatos>> GetCont(int id)
        {
            var contato = await _context.Contatos.FindAsync(id);
            if (contato is null)
                return NotFound("Contato não encontrado.");
                
            return Ok(contato);
        }
        [HttpPost]
        public async Task<ActionResult<List<Contatos>>> AddCont(Contatos contatos)
        {
            _context.Contatos.Add(contatos); 
            await _context.SaveChangesAsync(); 

            return Ok(await _context.Contatos.ToListAsync()); 
        }
        [HttpPut]
        public async Task<ActionResult<List<Contatos>>> UpdateCont(Contatos contatos)
        {
            var dbContato = await _context.Contatos.FindAsync(contatos.Id);
            if (dbContato is null)
                return NotFound("Contato não encontrado.");

            dbContato.Nome = contatos.Nome;
            dbContato.Email = contatos.Email;
            dbContato.Cpf = contatos.Cpf;

            await _context.SaveChangesAsync();

            return Ok(await _context.Contatos.ToListAsync());
        } 
        [HttpDelete]
        public async Task<ActionResult<List<Contatos>>> DeleteCont(int id)
        {
            var dbContato = await _context.Contatos.FindAsync(id);
            if (dbContato is null)
                return NotFound("Contato não encontrado.");

            _context.Contatos.Remove(dbContato);
            await _context.SaveChangesAsync();

            return Ok(await _context.Contatos.ToListAsync());
        }


    }
}
