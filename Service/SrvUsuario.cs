using Domain;
using Repository.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class SrvUsuario
    {
        RepUsuario _repUsuario;
        public SrvUsuario()
        {
            _repUsuario = new RepUsuario();
        }

        public void Salvar(Usuario usuario)
        {
            _repUsuario.Salvar(usuario);
        }
    }
}
