using Dapper;
using EasyTaskMangmentDomain.Infra.Repository;
using EasyTaskMangmentDomain.Infra.Util;
using EasyTaskMangmentDomain.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EasyTaskMangmentInfra.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly IDapperExecutor _dapperExecutor;
        private readonly IBaseQueries _queries;

        public BaseRepository(IDapperExecutor dapperExecutor, IBaseQueries queries)
        {
            _dapperExecutor = dapperExecutor;
            _queries = queries;
        }
        public async Task<bool> Delete(int id)
        {
            return await _dapperExecutor.ExecuteQuery(async con =>
            {
                using var transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
                int rowsAffected = await con.ExecuteAsync(_queries.DeleteQuery, new { id });
                bool status = rowsAffected > 0;
                transaction.Complete();
                return status;
            });
        }

        public async Task<List<T>> GetAllActive()
        {
            IEnumerable<T> result = await _dapperExecutor.GetAll<T>(_queries.GetAllActiveQuery);
            return result.ToList();
        }

        public async Task<T> GetById(int id)
        {
            return await _dapperExecutor.FirstOrDefaultAsync<T>(_queries.GetByIdQuery, new { id });
        }

        public async Task<int> Insert(T entity)
        {
            return await _dapperExecutor.ExecuteQuery<int>(async con =>
            {
                using var transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
                int rowsAffected = await con.ExecuteScalarAsync<int>(_queries.InsertQuery, entity);
                transaction.Complete();
                return rowsAffected; // Assumes entity has Id property
            });
        }

        public async Task<bool> Update(T entity)
        {
            return await _dapperExecutor.ExecuteQuery(async con =>
            {
                using var transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
                int rowsAffected = await con.ExecuteAsync(_queries.UpdateQuery, entity);
                bool status = rowsAffected > 0;
                transaction.Complete();
                return status;
            });
        }
    }
}
