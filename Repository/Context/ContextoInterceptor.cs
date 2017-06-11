using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Domain;

namespace Repository.Context
{
    public partial class ContextoEF
    {
        public override int SaveChanges()
        {
            IEnumerable<DbEntityEntry> modifiedEntities = ChangeTracker.Entries().Where(p => p.State == EntityState.Modified || p.State == EntityState.Deleted);
            foreach (DbEntityEntry change in modifiedEntities)
            {
                EntityState state = change.State;
                IRastreavel rastreavel = change.Entity as IRastreavel;
                BaseModelo baseModelo = change.Entity as BaseModelo;
                if (rastreavel == null)
                    continue;

                string nomeEntidade = change.Entity.GetType().Name;
                foreach (string prop in change.OriginalValues.PropertyNames)
                {
                    if (state == EntityState.Modified)
                        RastrearUpdate(change, prop, nomeEntidade, rastreavel, baseModelo);
                    else
                        RastrearDelete(change, prop, nomeEntidade, rastreavel, baseModelo);
                }
            }

            return base.SaveChanges();
        }

        private void RastrearDelete(DbEntityEntry change, string prop, string nomeEntidade, IRastreavel rastreavel, BaseModelo baseModelo)
        {
            if (change.OriginalValues[prop] != null)
            {
                string originalValue = change.OriginalValues[prop].ToString();
                Rastro rastro = new Rastro(nomeEntidade, baseModelo.Id, prop, originalValue, null, TipoRastro.Delete);
                Rastros.Add(rastro);
            }
        }

        private void RastrearUpdate(DbEntityEntry change, string prop, string nomeEntidade, IRastreavel rastreavel, BaseModelo baseModelo)
        {
            if (change.OriginalValues[prop] == null || change.CurrentValues[prop] == null)
                return;
            string originalValue = change.OriginalValues[prop].ToString();
            string currentValue = change.CurrentValues[prop].ToString();
            if (originalValue == currentValue)
                return;

            Rastro rastro = new Rastro(nomeEntidade, baseModelo.Id, prop, originalValue, currentValue, TipoRastro.Update);
            Rastros.Add(rastro);
        }
    }
}
