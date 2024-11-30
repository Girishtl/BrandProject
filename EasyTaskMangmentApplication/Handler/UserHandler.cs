using AutoMapper;
using EasyTaskMangmentDomain.Handler;
using EasyTaskMangmentDomain.Infra.Repository;
using EasyTaskMangmentDomain.Models.DTO;
using EasyTaskMangmentDomain.Models.Request;
using EasyTaskMangmentDomain.Models.Response;

namespace EasyTaskMangmentApplication.Handler
{
    public class UserHandler : IUserHanlder
    {
        private IUserRepository _userRepository;

        private IMapper _mapper { get; set; }


        public UserHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;

        }

        public async Task<List<UserResponse>> GetAllActiveUser()
        {
            List<UserResponse> lst = _mapper.Map<List<UserResponse>>(await _userRepository.GetAllActive());
            return lst;
        }

        public async Task<int> InsertUser(CreateUserRequest createUser)
        {
            return await _userRepository.Insert(_mapper.Map<UserDTO>(createUser));


        }

        public async Task<bool> UpdateUser(UpdateUserRequest updateUserRequest)
        {
            return await _userRepository.Update(_mapper.Map<UserDTO>(updateUserRequest));
        }

        public async Task<bool> DeleteUser(int id)
        {
            return await _userRepository.Delete(id);
        }


    }
}
