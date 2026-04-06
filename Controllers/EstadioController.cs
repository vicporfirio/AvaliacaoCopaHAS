using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaHAS.Data;
using CopaHAS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CopaHAS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstadioController : ControllerBase
    {
        
        private readonly DataContext _context;

        public EstadioController(DataContext context)
        {
            _context = context;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Estadio> list = await _context.TB_ESTADIOS.ToListAsync();
                return Ok(list);
                
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message + " - " + ex.InnerException);
            }
        }
        [HttpPost("Posta")]
        public async Task<IActionResult> Add(Estadio novoEstadio)
        {
            try
            {
                await _context.TB_ESTADIOS.AddAsync(novoEstadio);
                await _context.SaveChangesAsync();
                List<Estadio> list = await _context.TB_ESTADIOS.ToListAsync();
                return Ok(list);

            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message + " - " + ex.InnerException);
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Estadio eRemover = await _context.TB_ESTADIOS
                    .FirstOrDefaultAsync(p => p.Id == id);

                _context.TB_ESTADIOS.Remove(eRemover);
                int linhaAfetadas = await _context.SaveChangesAsync();
                List<Estadio> list = await _context.TB_ESTADIOS.ToListAsync();
                return Ok(list);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message + " - " + ex.InnerException);
            }
        }
    }
}