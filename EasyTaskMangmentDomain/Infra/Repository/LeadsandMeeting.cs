using EasyTaskMangmentDomain.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTaskMangmentDomain.Infra.Repository
{
    public interface ILeadsRepository :IBaseRepository<LeadDTO>
    {
    }

    public interface IMeetingRepository : IBaseRepository<MeetingDTO>
    {

    }
}
