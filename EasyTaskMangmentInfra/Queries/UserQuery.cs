using EasyTaskMangmentDomain.Queries;

namespace EasyTaskMangmentInfra.Queries
{
    public   class UserQuery : IUserQueries
    {
        public   string loginQuery => "select id,name,email_address,phone_number from appuser.users where  email_address = @email_address and password = @password";

        public  string GetAllActiveQuery => "SELECT u.id, u.name, u.phone_number, u.email_address, u.status, u.modified_date, u.create_date, u.modified_by, u.created_by, u.role_id, u.service_id, ur.name AS role_name, us.ServiceName AS service_name, u.deleted_by, u.deleted_date FROM appuser.users AS u JOIN appuser.userRole AS ur ON u.role_id = ur.id JOIN appuser.userService AS us ON u.service_id = us.id WHERE u.status = 'active';";

        public  string InsertQuery => "INSERT INTO appUser.users (name,phone_number, email_address,status,created_by, role_id, service_id) VALUES(@name,@phone_number, @email_address,'active',@created_by,@role_id, @service_id);";

        public  string UpdateQuery => "UPDATE appUser.users SET  name = @name, phone_number = @phone_number,email_address = @email_address, role_id = @role_id, service_id = @service_id, modified_by = @modified_by WHERE id = @id;";

        public  string DeleteQuery => "UPDATE appUser.users SET status = 'InActive'  WHERE id = @id";

        public  string GetByIdQuery => throw new NotImplementedException();
    }
}
