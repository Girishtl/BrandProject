namespace EasyTaskMangmentDomain.Models.Response
{
    public class UserResponse
    {
        public int id { get; set; }                           // Primary Key
        public required string name { get; set; }                      // User's name
        public required string phone_number { get; set; }              // Phone number, optional
        public required string email_address { get; set; }             // Unique email address
        public required string password { get; set; }                  // Hashed password
        public required string status { get; set; }                    // Status (e.g., active, inactive)
        public DateTime? modified_date { get; set; }          // Last modified timestamp
        public DateTime create_date { get; set; }             // Creation timestamp
        public required string modified_by { get; set; }               // Identifier of who modified the record
        public required string created_by { get; set; }                // Identifier of who created the record
        public int? role_id { get; set; }

        public string role_name { get; set; }// Foreign key to userRole table
        public int? service_id { get; set; }

        public string service_name { get; set; } // Foreign key to userService table
        public required string deleted_by { get; set; }                // Identifier of who deleted the record
        public DateTime? deleted_date { get; set; }           // Deletion timestamp
    }
}
