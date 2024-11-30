using EasyTaskMangmentDomain.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTaskMangmentInfra.Queries
{
    public class UserWorkQuery : IUserWorkQuery
    {
        public  string GetAllActiveQuery => "SELECT id, workname, workcost, workdescription, serviceid, createddate, modifieddate, createdby, modifiedby, deletedby, deleteddate FROM appuser.userworkdetails WHERE deleteddate IS NULL;";

        public  string InsertQuery => "INSERT INTO appuser.userworkdetails (workname, workcost, workdescription, serviceid, createddate, createdby) VALUES (@WorkName, @WorkCost,@WorkDescription, @ServiceId, CURRENT_TIMESTAMP, '@CreatedBy');";

        public  string UpdateQuery => "UPDATE appuser.userworkdetails SET workname = @WorkName, workcost = @workcost, workdescription = @workdescription, modifieddate = CURRENT_TIMESTAMP, modifiedby = @ModifiedBy WHERE id = @Id;";

        public  string DeleteQuery => "UPDATE appuser.userworkdetails SET  deleteddate = CURRENT_TIMESTAMP WHERE id = @Id; ";

        public string GetByIdQuery => throw new NotImplementedException();

      
    }
}
