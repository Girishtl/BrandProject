using Dapper;
using EasyTaskMangmentDomain.Infra.Repository;
using EasyTaskMangmentDomain.Infra.Util;
using EasyTaskMangmentDomain.Models.DTO;
using EasyTaskMangmentDomain.Models.Response;
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
    public class UserWorkRepository : BaseRepository<UserWorkDetailDTO>, IUserWorkRepository
    {

        public UserWorkRepository(IDapperExecutor dapperExecutor, IUserWorkQuery userWorkerQueries)
           : base(dapperExecutor, userWorkerQueries)
        { }


    }
}
