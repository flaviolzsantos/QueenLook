using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Home : BaseModelo
    {
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public bool Ativo { get; set; } = true;
    }
}
