using EasyTaskMangmentDomain.Models.DTO;

namespace EasyTaskMangmentDomain.Infra.Repository
{
    public interface IUserRepository : IBaseRepository<UserDTO>
    {
                
            Task<UserDTO> GetLoginUser(string username, string password);
        
    }
}
