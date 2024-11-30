namespace EasyTaskMangmentDomain.Models.Response
{
    public class UserLoginResponse
    {
               
        public required string Name { get; set; }            // Maps to "name" column
        public required string PhoneNumber { get; set; }     // Maps to "phone_number" column
        public required string EmailAddress { get; set; }    // Maps to "email_address" column (unique)

        public int? role_id { get; set; }                     // Foreign key to userRole table
        public int? service_id { get; set; }

    }
}
