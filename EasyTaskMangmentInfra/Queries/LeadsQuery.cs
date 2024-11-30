using EasyTaskMangmentDomain.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTaskMangmentInfra.Queries
{
    public class LeadsQuery : ILeadsQuery
    {
        public string GetAllActiveQuery => "SELECT l.id, l.customer_name, l.email_address, l.alt_email_address, l.phone_number, l.alt_phone_number, l.status,ls.LeadName AS statusname, l.city, l.address, l.created_date, l.modified_by, l.modified_date, l.deleted_by, l.deleted_date, l.instant_meeting_created, STRING_AGG(us.ServiceName, ', ') AS services,l.service, ls.IsActive FROM customerLeads.leads l LEFT JOIN appuser.userService us ON POSITION(CAST(us.id AS TEXT) IN l.service) > 0 LEFT JOIN customerLeads.LeadStatus ls ON ls.LeadID = l.id WHERE l.deleted_date IS NULL GROUP BY l.id, l.customer_name, l.email_address, l.alt_email_address, l.phone_number, l.alt_phone_number, l.status, l.city, l.address, l.created_date, l.modified_by, l.modified_date, l.deleted_by, l.deleted_date, l.instant_meeting_created,ls.LeadName, ls.IsActive;";

        public string GetByIdQuery => throw new NotImplementedException();

        public string InsertQuery => "INSERT INTO customerLeads.leads (customer_name, email_address, alt_email_address, phone_number, alt_phone_number, status, service, city, address, created_date) VALUES (@customer_name, @email_address, @alt_email_address, @phone_number, @alt_phone_number, @status, @service, @City, @Address, CURRENT_TIMESTAMP)   RETURNING id;";

        public string UpdateQuery => "UPDATE customerLeads.leads SET customer_name = @customer_name, email_address = @email_address, alt_email_address = @alt_email_address, phone_number = @phone_number, alt_phone_number = @alt_phone_number, status = @status, service = @service, city = @city, address = @address, modified_date = CURRENT_TIMESTAMP, modified_by = @modified_by  WHERE id = @Id;";

        public string DeleteQuery => "UPDATE customerLeads.leads SET  deleted_date = CURRENT_TIMESTAMP  WHERE id = @Id;";
    }
}
