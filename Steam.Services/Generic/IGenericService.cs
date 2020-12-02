using System.Collections.Generic;

namespace Steam.Services.Generic
{
    public interface IGenericService<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);

        void Delete(object id);
        void Save();
    }
}