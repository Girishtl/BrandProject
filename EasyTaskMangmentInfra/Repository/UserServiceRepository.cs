using Dapper;
using EasyTaskMangmentDomain.Infra.Repository;
using EasyTaskMangmentDomain.Infra.Util;
using EasyTaskMangmentDomain.Models.DTO;
using EasyTaskMangmentDomain.Queries;
using EasyTaskMangmentInfra.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EasyTaskMangmentInfra.Repository
{
    public class UserServiceRepository : BaseRepository<userServiceDTO>, IUserServiceRepository
    {
        public UserServiceRepository(IDapperExecutor dapperExecutor, IUserServiceQueries userServiceQueries)
            : base(dapperExecutor, userServiceQueries)
        { }




    }
}
