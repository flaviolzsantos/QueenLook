using Domain;
using Repository.Repositorio.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Sistema
{
    public class SrvErro
    {
        RepErro _repErro;

        public void SalvarErro(Erro erro)
        {
            _repErro.Salvar(erro);
        }

        public SrvErro()
        {
            _repErro = new RepErro();
        }
    }
}
