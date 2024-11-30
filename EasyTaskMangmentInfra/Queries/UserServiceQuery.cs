using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EasyTaskMangmentDomain.Queries;

namespace EasyTaskMangmentInfra.Queries
{
    public  class UserServiceQuery : IUserServiceQueries
    {
        public  string GetAllActiveQuery => "SELECT id,servicename,servicecost,servicedescription,createddate,createdby,modifieddate,modifiedby FROM  appuser.userservice WHERE deleteddate IS  NULL";

        public  string InsertQuery => "INSERT INTO appuser.userservice (servicename, servicecost, servicedescription,createdby) VALUES (@ServiceName, @ServiceCost, @ServiceDescription, @createdby);";

        public  string UpdateQuery => "UPDATE appuser.userservice SET servicename = @ServiceName, servicecost = @ServiceCost, servicedescription = @ServiceDescription, isactive = @IsActive, modifieddate = CURRENT_TIMESTAMP, modifiedby = @ModifiedBy WHERE id = @Id;";

        public  string DeleteQuery => "UPDATE appuser.userservice SET deletedby = @deletedby, deleteddate = CURRENT_TIMESTAMP WHERE id = @id; ";
        public string GetByIdQuery => throw new NotImplementedException();

     
    }
}
