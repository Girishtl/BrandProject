namespace EasyTaskMangmentDomain.Models.Response
{
    public class LoginResponse
    {
        public int Id { get; set; }                 // Maps to "id" column (auto-incrementing primary key)
        public required string Name { get; set; }            // Maps to "name" column
        public required string PhoneNumber { get; set; }     // Maps to "phone_number" column
        public required string EmailAddress { get; set; }    // Maps to "email_address" column (unique)


    }
}
