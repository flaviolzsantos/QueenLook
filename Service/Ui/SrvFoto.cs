using Domain;
using Repository.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Ui
{
    public class SrvFoto
    {       

        public SrvFoto()
        {
        }

        public void SalvarFotoSuperior(FotoSuperior fotoSuperior)
        {
            RepFoto<FotoSuperior> repFoto = new RepFoto<FotoSuperior>();
            repFoto.Salvar(fotoSuperior);
        }

    }
}
