
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChatAPI.Repositories
{
    public interface IRepository<E> where E : class
    {
        BlazorChatDbContext Context { get; set; }
        IEnumerable<E> FindAll();
        E Find(long id);
        bool Add(E entity);
        bool AddAll(IEnumerable<E> entities);
        bool Update(E entity);
        bool UpdateAll(IEnumerable<E> entities);
        bool Delete(long id);
        bool DeleteAll(IEnumerable<long> ids);
    }
}