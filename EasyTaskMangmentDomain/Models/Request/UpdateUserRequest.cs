using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTaskMangmentDomain.Models.Request
{
    public class UpdateUserRequest
    {
        public int id { get; set; }
        public string name { get; set; }                      // User's name
        public string phone_number { get; set; }              // Phone number, optional
        public string email_address { get; set; }             // Unique email address

  
        public string created_by { get; set; }

        public int? role_id { get; set; }                     // Foreign key to userRole table
        public int? service_id { get; set; }
    }
}
