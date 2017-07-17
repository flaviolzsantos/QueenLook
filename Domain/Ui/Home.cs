using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util.Exceptions;

namespace Domain
{
    public class Home : BaseModelo
    {
        private string _titulo;
        private string _conteudo;

        public string Titulo
        {
            get { return _titulo; }
            //set
            //{

            //    if (value == "" || value == null)
            //        throw new RegraNegocioException("Titulo é obrigatório");

            //    _titulo = value;
            //}
            set { _titulo = value; }
        }
        public string Conteudo { get; set; }
        public bool Ativo { get; set; } = true;

        public void AtivarOuDesativar()
        {
            Ativo = !Ativo;
        }
    }
}
