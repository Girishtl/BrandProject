using AutoMapper;
using EasyTaskMangmentDomain.Infra.Repository;
using EasyTaskMangmentDomain.Models.DTO;
using EasyTaskMangmentDomain.Models.Request;
using EasyTaskMangmentDomain.Models.Response;

namespace EasyTaskMangmentApplication.Handler
{
    public class UserWorkerHandler : IUserWorkHandler
    {
        private IUserWorkRepository _userWorkRepository;

        private IMapper _mapper { get; set; }


        public UserWorkerHandler(IUserWorkRepository userWorkRepository, IMapper mapper)
        {
            _userWorkRepository = userWorkRepository;
            _mapper = mapper;

        }
        public Task<bool> DeleteUserServiceResponse(int id)
        {
            return _userWorkRepository.Delete(id);
        }

        public async Task<List<UserWorkResponse>> GetUserServiceResponse()
        {
            return _mapper.Map<List<UserWorkResponse>>(await _userWorkRepository.GetAllActive());
        }

        public Task<int> InsertUserServiceResponse(UserWorkCreateRequest userServiceResponse)
        {
            return _userWorkRepository.Insert(_mapper.Map<UserWorkDetailDTO>(userServiceResponse));
        }

        public Task<bool> UpdateUserServiceResponse(UserWorkUpdateRequest userServiceResponse)
        {
            return _userWorkRepository.Update(_mapper.Map<UserWorkDetailDTO>(userServiceResponse));
        }

    }
}
