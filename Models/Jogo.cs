using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaHAS.Models;

namespace AvaliacaoCopaHAS.Models
{
    public class Jogo
    {
        public int Id { get ; set; }
        public DateTime DataHora { get; set; }
        public int EstadioId { get; set; }//FL
        public Estadio EstadioIdNavegacao { get; set; }
        //N:N
        public List <JogoSelecao> Jogoselecoes { get; set; }
            = new List<JogoSelecao>(); 
    }
}