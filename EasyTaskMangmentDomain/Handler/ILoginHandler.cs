using EasyTaskMangmentDomain.Models.Request;
using EasyTaskMangmentDomain.Models.Response;

namespace EasyTaskMangmentDomain.Handler
{
    public interface ILoginHandler
    {

        public Task<UserLoginResponse> CheckLogin(UserLoginRequest loginRequest);
    }
}
