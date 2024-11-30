using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTaskMangmentDomain.Infra.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        Task<List<T>> GetAllActive();
        Task<T> GetById(int id);
        Task<int> Insert(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(int id);
    }
}
