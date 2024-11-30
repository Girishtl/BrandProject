using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTaskMangmentDomain.Models.DTO
{

    public class MeetingDTO
    {
        public int meeting_id { get; set; }                // meeting_id
        public int lead_id { get; set; }                   // lead_id

        public string customer_name { get; set; }
        public string meeting_location { get; set; }       // meeting_location
        public int? meeting_status { get; set; }           // meeting_status (nullable int, as it may be null)
        public int? assign_to { get; set; }                // assign_to (nullable int, if no user is assigned)
        public string meeting_notes { get; set; }          // meeting_notes
        public DateTime? meeting_date { get; set; }        // meeting_date (nullable DateTime)
        public TimeSpan? meeting_time { get; set; }        // meeting_time (nullable TimeSpan)
        public string created_by { get; set; }             // created_by
        public DateTime created_date { get; set; }         // created_date
        public string modified_by { get; set; }            // modified_by
        public DateTime? modified_date { get; set; }       // modified_date (nullable DateTime)
        public string deleted_by { get; set; }             // deleted_by
        public DateTime? deleted_date { get; set; }        // deleted_date (nullable DateTime)
    }
}
