using EasyTaskMangmentDomain.Models.DTO;
using EasyTaskMangmentDomain.Models.Request;
using EasyTaskMangmentDomain.Models.Response;

namespace EasyTaskMangmentDomain.Handler
{
    public interface IUserHanlder
    {

        Task<List<UserResponse>> GetAllActiveUser();

        Task<int> InsertUser(CreateUserRequest createUser);

        Task<bool> UpdateUser(UpdateUserRequest updateUser);


        Task<bool> DeleteUser(int id);


    }
}
