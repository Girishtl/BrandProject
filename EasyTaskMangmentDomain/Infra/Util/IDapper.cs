using System.Data;

namespace EasyTaskMangmentDomain.Infra.Util
{

    public interface IDapperExecutor
    {
        Task<T> ExecuteQuery<T>(Func<IDbConnection, Task<T>> operation);
        Task ExecuteQuery<T>(Func<IDbConnection, Task> operation);
        Task<T> FirstOrDefaultAsync<T>(string sql, object? parameters = null);
        Task<IEnumerable<T>> GetAll<T>(string sql, object? parameters = null);
        Task<int> Insert<T>(string sql, object? parameters = null);
    }

}
