using Dapper;
using EasyTaskMangmentDomain.Infra.Util;
using EasyTaskMangmentDomain.Models.Config;
using Microsoft.Extensions.Options;
using Npgsql;
using System.Data;
using System.Transactions;

namespace EasyTaskMangmentInfra.Util
{
    public class DapperExecutor : IDapperExecutor
    {
        private DbConfiguration DbConfiguration { get; }

        public DapperExecutor(IOptions<DbConfiguration> options) => DbConfiguration = options.Value;

        private async Task<NpgsqlConnection> InitializeConnection(string connectionstring = "")
        {
            NpgsqlConnection sqlconnection = string.IsNullOrWhiteSpace(connectionstring) ? new NpgsqlConnection(DbConfiguration.Connection) : new NpgsqlConnection(connectionstring);
            await sqlconnection.OpenAsync();
            return sqlconnection;
        }


        public async Task<T> ExecuteQuery<T>(Func<IDbConnection, Task<T>> operation)
        {
            try
            {
                using NpgsqlConnection connection = await InitializeConnection();
                return await operation(connection);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task ExecuteQueryWithTransaction<T>(Func<IDbConnection, Task> operation)
        {
            using TransactionScope tscn = new TransactionScope();
            try
            {
                using NpgsqlConnection connection = await InitializeConnection();
                await operation(connection);
                tscn.Complete();
            }
            catch (Exception)
            {
                throw;
            }

        }


        /// <summary>
        /// For methods that dont return anything
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="operation"></param>
        /// <returns></returns>
        public async Task ExecuteQuery<T>(Func<IDbConnection, Task> operation)
        {
            using NpgsqlConnection connection = await InitializeConnection();
            await operation(connection);
        }


        //Samples on how to use the ExecuteQuery method
        public async Task<IEnumerable<T>> GetAll<T>(string sql, object? parameters = null)
            => await ExecuteQuery(async con => await con.QueryAsync<T>(sql, parameters));

        public async Task<T> FirstOrDefaultAsync<T>(string sql, object? parameters = null)
            => await ExecuteQuery(async con => await con.QueryFirstOrDefaultAsync<T>(sql, parameters));

        public async Task<int> Insert<T>(string sql, object? parameters = null)
            => await ExecuteQuery<int>(async con => await con.ExecuteAsync(sql, parameters));
    }
}
