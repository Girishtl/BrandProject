using EasyTaskMangmentDomain.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTaskMangmentInfra.Queries
{
    internal class MeetingQuery : IMeetingQuery
    {
        public string GetAllActiveQuery => "SELECT m.meeting_id, m.lead_id, m.meeting_location, m.meeting_status, m.assign_to, m.meeting_notes, m.meeting_date, m.meeting_time, m.created_by AS meeting_created_by, m.created_date AS meeting_created_date, m.modified_by AS meeting_modified_by, m.modified_date AS meeting_modified_date, m.deleted_by AS meeting_deleted_by, m.deleted_date AS meeting_deleted_date, l.id AS lead_id, l.customer_name, l.email_address, l.alt_email_address, l.phone_number, l.alt_phone_number, l.status AS lead_status, l.service, l.city, l.address, l.created_date AS lead_created_date, l.modified_by AS lead_modified_by, l.modified_date AS lead_modified_date, l.deleted_by AS lead_deleted_by, l.deleted_date AS lead_deleted_date FROM customerLeads.meeting m LEFT JOIN customerLeads.leads l ON l.id = m.lead_id WHERE m.deleted_date IS NULL;";

        public string InsertQuery  => "INSERT INTO customerLeads.meeting (lead_id, meeting_location, meeting_status, assign_to, meeting_notes, meeting_date, meeting_time)VALUES (@lead_id, @meeting_location, @meeting_status, @assign_to, @meeting_notes, @meeting_date, @meeting_time) RETURNING meeting_id;";

        public string GetByIdQuery => throw new NotImplementedException();

        public string UpdateQuery => "UPDATE customerLeads.meeting SET lead_id = @lead_id,meeting_location = @meeting_location,meeting_status = @meeting_status,meeting_date =@meeting_date,meeting_time = @meeting_time, modified_date = CURRENT_TIMESTAMP  WHERE meeting_id = @meeting_id;";

        public string DeleteQuery => "UPDATE customerLeads.meeting SET  deleted_date = CURRENT_TIMESTAMP  WHERE meeting_id = @Id;";
    }
}
