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
    public class JogosSelecoesController : ControllerBase
    {
        private readonly DataContext _context;//using CopaHas.Data

        public JogosSelecoesController(DataContext context)
        {
            _context = context;
        }

        
    }
}