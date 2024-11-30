using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTaskMangmentDomain.Models.DTO
{
   
        public class LeadDTO
        {



            public int Id { get; set; }                          // Corresponds to 'id' column (primary key)
            public string customer_name { get; set; }              // Corresponds to 'customer_name' column
            public string email_address { get; set; }              // Corresponds to 'email_address' column
            public string alt_email_address { get; set; }           // Corresponds to 'alt_email_address' column
            public string phone_number { get; set; }               // Corresponds to 'phone_number' column
            public string alt_phone_number { get; set; }            // Corresponds to 'alt_phone_number' column
            public int status { get; set; }                       // Corresponds to 'status' column (e.g., 0, 1, 2)
            
           public string statusname { get; set; }  
            public string service { get; set; }
            public string services { get; set; }                    // Corresponds to 'service' column
            public string city { get; set; }                      // Corresponds to 'city' column
            public string address { get; set; }                   // Corresponds to 'address' column
            public DateTime created_date { get; set; }             // Corresponds to 'created_date' column
            public string modified_by { get; set; }                // Corresponds to 'modified_by' column
            public DateTime? modified_date { get; set; }           // Corresponds to 'modified_date' column (nullable DateTime)
            public string deleted_by { get; set; }                 // Corresponds to 'deleted_by' column
            public DateTime? deleted_date { get; set; }            // Corresponds to 'deleted_date' column (nullable DateTime)
            public bool instant_meeting_created { get; set; }       // Corresponds to 'instant_meeting_created' column (true/false)
        }
    

}
