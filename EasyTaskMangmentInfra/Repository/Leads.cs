using EasyTaskMangmentDomain.Infra.Repository;
using EasyTaskMangmentDomain.Infra.Util;
using EasyTaskMangmentDomain.Models.DTO;
using EasyTaskMangmentDomain.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTaskMangmentInfra.Repository
{
    public class LeadsRepository : BaseRepository<LeadDTO>,ILeadsRepository
    {
        public LeadsRepository(IDapperExecutor dapperExecutor, ILeadsQuery userServiceQueries)
           : base(dapperExecutor, userServiceQueries)
        { }
    }

    public class MeetingRepository : BaseRepository<MeetingDTO>,IMeetingRepository
    {
        public MeetingRepository(IDapperExecutor dapperExecutor, IMeetingQuery userServiceQueries)
          : base(dapperExecutor, userServiceQueries)
        { }

    }
}
