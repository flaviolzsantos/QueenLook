using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class BaseFoto : BaseModelo
    {
        public string Caminho { get; set; }
        public int Tamanho { get; set; }
        public int Largura { get; set; }
    }
}
