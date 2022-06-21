using System;
using System.Threading.Tasks;

namespace LeanUniversity.Contracts.Generics
{
    public interface IGenericActionDbAddUpdate<T> where T:class
    {
        Task<Tuple<T, bool>> AddAsync(T entity);
        Task<Tuple<T, bool>> UpdateAsync(T entity);
    }
}
