using Domain;
using Repository.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util.Exceptions;

namespace Service.Ui
{
    public class SrvHome
    {
        RepHome _repHome;
        public SrvHome()
        {
            _repHome = new RepHome();
        }


        public void SalvarHome(Home home)
        {
            if (_repHome.ExisteTresConteudosAtivos())
                throw new RegraNegocioException("Já existe 3 conteúdos cadastrados ativos, desative algum para prosseguir");

            _repHome.Salvar(home);
        }

        public Home[] ObterListaHome()
        {
            return _repHome.ObterListaHome();
        }

        public void DeletarHome(int id)
        {
            Home home = _repHome.ObterPor(id);
            _repHome.Deletar(home);
        }
        
                
    }
}
