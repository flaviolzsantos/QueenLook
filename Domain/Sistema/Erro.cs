using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Erro : BaseModelo
    {
        public string Controller { get; set; }
        public TipoErro TipoErro { get; set; }
        public string DescricaoErro { get; set; }

        public Erro(string controller, TipoErro tipoErro, string descricaoErro)
        {
            this.Controller = controller;
            this.TipoErro = tipoErro;
            this.DescricaoErro = descricaoErro;
        }
        public Erro() { }
    }
}
