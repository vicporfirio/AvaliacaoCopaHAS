using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AvaliacaoCopaHAS.Models;
using CopaHAS.Data;

namespace AvaliacaoCopaHAS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TecnicosController : ControllerBase
    {
        private readonly DataContext _context;//using CopaHas.Data

        public TecnicosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")] //Buscar pelo id
        public async Task<IActionResult> GetSingle(int id)
        {
            try
            {
                Tecnico tecnico = await _context.TB_TECNICOS
                    .FirstOrDefaultAsync(eBusca => eBusca.Id == id);

                return Ok(tecnico);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message + "-" + ex.InnerException);
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Tecnico> lista = await _context.TB_TECNICOS
                    .Include(s => s.SelecaoIdNavegacao).ToListAsync();
                return Ok(lista);
            }
            catch (SystemException ex)
            {
                return BadRequest(ex.Message + "-" + ex.InnerException);
            }
        }
    }
}