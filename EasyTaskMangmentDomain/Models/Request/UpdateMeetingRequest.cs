using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTaskMangmentDomain.Models.Request
{
    public class UpdateMeetingRequest
    {
        public int meeting_id { get; set; }
        public int lead_id { get; set; }                   // lead_id


        public string meeting_location { get; set; }       // meeting_location
        public int? meeting_status { get; set; }           // meeting_status (nullable int, as it may be null)
        public int? assign_to { get; set; }                // assign_to (nullable int, if no user is assigned)
        public string meeting_notes { get; set; }          // meeting_notes
        public DateTime? meeting_date { get; set; }        // meeting_date (nullable DateTime)
        public string meeting_time
        {
            get; set;
        }
    }
}
