using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaHAS.Models;

namespace AvaliacaoCopaHAS.Models
{
    public class Selecao
    {
        public int Id {get; set;}
        public string Pais {get;set;} = string.Empty;
        //1;N
        public List<Jogador> Jogadores{get; set;} = new List<Jogador>();
         // 1:1
         public Tecnico Tecnico {get;set;} = null;
         public List<JogoSelecao> JogosSelecoes {get;set;} = new List<JogoSelecao>();

    }
}