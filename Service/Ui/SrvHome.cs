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
            if (home.Titulo == "" || home.Titulo == null)
                throw new RegraNegocioException("Titulo é obrigatório");

                if (home.Id > 0)
                _repHome.Atualizar(home);
            else
            {
                ValidarConteudoAtivo();
                _repHome.Salvar(home);
            }
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

        public void AtivarOuDesativar(int id)
        {
            Home home = _repHome.ObterPor(id);

            if (!home.Ativo)
                ValidarConteudoAtivo();

            home.AtivarOuDesativar();
            _repHome.Atualizar(home);
        }

        public object ObterHomeUi()
        {
            return _repHome.ObterListaHomeUi();
        }

        #region Metodos de suporte
        private void ValidarConteudoAtivo()
        {
            if (_repHome.ExisteTresConteudosAtivos())
                throw new RegraNegocioException("Já existe 3 conteúdos cadastrados ativos, desative algum para prosseguir");
        }
        #endregion


    }
}
