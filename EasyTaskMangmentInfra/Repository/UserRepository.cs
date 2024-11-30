using Dapper;
using EasyTaskMangmentDomain.Infra.Repository;
using EasyTaskMangmentDomain.Infra.Util;
using EasyTaskMangmentDomain.Models.DTO;
using EasyTaskMangmentDomain.Queries;
using EasyTaskMangmentInfra.Queries;
using System.Transactions;

namespace EasyTaskMangmentInfra.Repository
{
    public class UserRepository : BaseRepository<UserDTO>, IUserRepository
    {
        protected readonly IDapperExecutor _dapperExecutor;
        private readonly IUserQueries _queries;
        public UserRepository(IDapperExecutor dapperExecutor, IUserQueries userQueries)
         : base(dapperExecutor, userQueries)
        {
            _dapperExecutor = dapperExecutor;
            _queries = userQueries;
        }

        public async Task<UserDTO> GetLoginUser(string username, string passWord)
        {
            return await _dapperExecutor.FirstOrDefaultAsync<UserDTO>(_queries.loginQuery, new { email_address = username, password = passWord });
        }
        
    }
    }
