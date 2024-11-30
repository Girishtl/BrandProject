using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTaskMangmentDomain.Queries
{
    public interface IBaseQueries
    {
        string GetAllActiveQuery { get; }
        string GetByIdQuery { get; }
        string InsertQuery { get; }
        string UpdateQuery { get; }
        string DeleteQuery { get; }
    }
    public interface IUserQueries : IBaseQueries {
        string  loginQuery { get; } 

    }

    public interface IUserServiceQueries : IBaseQueries { }

    public interface IUserWorkQuery : IBaseQueries { }

    public interface ILeadsQuery : IBaseQueries { }

    public interface IMeetingQuery : IBaseQueries { }
}
