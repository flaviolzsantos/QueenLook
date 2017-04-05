using Domain;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;


namespace Repository
{
    public class RepBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        ContextoEF context = new ContextoEF();

        public void Salvar(TEntity obj)
        {
            context.Set<TEntity>().Add(obj);
            context.SaveChanges();

        }

        public void Atualizar(TEntity obj)
        {
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Deletar(TEntity obj)
        {
            context.Set<TEntity>().Remove(obj);
            context.SaveChanges();
        }

        public TEntity ObterPor(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public IList<TEntity> ObterTodos()
        {
            return null;
        }
    }
}
