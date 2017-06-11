using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositorio
{
    
    public class RepHome : RepBase<Home>
    {
        public bool ExisteTresConteudosAtivos()
        {
            return (from x in GetContext().Homes where x.Ativo select x.Id).Count() == 3;
        }

        public Home[] ObterListaHome()
        {
            return (from x in GetContext().Homes select x).ToArray();
        }
    }
}
