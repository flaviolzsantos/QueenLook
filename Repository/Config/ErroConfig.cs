using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Config
{
    public class ErroConfig : EntityTypeConfiguration<Erro>
    {
        public ErroConfig()
        {
            Property(x => x.DescricaoErro).HasMaxLength(4000);
        }
    }
}
