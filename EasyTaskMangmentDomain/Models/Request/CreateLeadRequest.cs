using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTaskMangmentDomain.Models.Request
{
    public  class CreateLeadRequest
    {
        public string customer_name { get; set; }              // Corresponds to 'customer_name' column
        public string email_address { get; set; }              // Corresponds to 'email_address' column
        public string alt_email_address { get; set; }           // Corresponds to 'alt_email_address' column
        public string phone_number { get; set; }               // Corresponds to 'phone_number' column
        public string alt_phone_number { get; set; }            // Corresponds to 'alt_phone_number' column
        public int status { get; set; }                       // Corresponds to 'status' column (e.g., 0, 1, 2)

        
        public string service { get; set; }
                        // Corresponds to 'service' column
        public string city { get; set; }                      // Corresponds to 'city' column
        public string address { get; set; }                   // Corresponds to 'address' column

    }
}
