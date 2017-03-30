using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IRepositoryBase<T> where T : class
    {
        void Adicionar(T obj);        
        void Atualizar(T obj);
        void Deletar(T obj);
        T ObterPor(int id);
        IList<T> ObterTodos();
    }
}
