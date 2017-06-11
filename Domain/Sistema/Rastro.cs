using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Rastro : BaseModelo
    {
        public Rastro(string nomeEntidade, int idObjeto, string propriedade, string valorAnterior, string valorAtual, TipoRastro update)
        {
            NomeEntidade = nomeEntidade;
            IdObjeto = idObjeto;
            Propriedade = propriedade;
            ValorAnterior = valorAnterior;
            ValorAtual = valorAtual;
            Tipo = update;
        }

        public TipoRastro Tipo { get; set; }
        public string NomeEntidade { get; set; }
        public int IdObjeto { get; set; }
        public string Propriedade { get; set; }
        public string ValorAnterior { get; set; }
        public string ValorAtual { get; set; }
    }
}
