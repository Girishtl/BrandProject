using AutoMapper;
using EasyTaskMangmentDomain.Handler;
using EasyTaskMangmentDomain.Infra.Repository;
using EasyTaskMangmentDomain.Models.Request;
using EasyTaskMangmentDomain.Models.Response;

namespace EasyTaskMangmentApplication.Handler
{
    public class LoginHandler : ILoginHandler
    {
        private IUserRepository _userRepository { get; set; }

        private IMapper _mapper { get; set; }

        public LoginHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserLoginResponse> CheckLogin(UserLoginRequest loginRequest)
        {

            UserLoginResponse x = _mapper.Map<UserLoginResponse>(await _userRepository.GetLoginUser(loginRequest.userName, loginRequest.password));

            return x;
        }




    }
}
