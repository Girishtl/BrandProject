using AutoMapper;
using EasyTaskMangmentDomain.Infra.Repository;
using EasyTaskMangmentDomain.Models.DTO;
using EasyTaskMangmentDomain.Models.Request;
using EasyTaskMangmentDomain.Models.Response;
using EasyTaskMangmentInfra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTaskMangmentApplication.Handler
{
    public class UserServieHandler : IUserServieHandler
    {
        private IUserServiceRepository _userRepository;

        private IMapper _mapper { get; set; }


        public UserServieHandler(IUserServiceRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;

        }
        public Task<bool> DeleteUserServiceResponse(int id)
        {
            return _userRepository.Delete(id);
        }

        public async Task<List<userServiceResponse>> GetUserServiceResponse()
        {
            return _mapper.Map<List<userServiceResponse>>(await _userRepository.GetAllActive());
        }

        public Task<int> InsertUserServiceResponse(userServiceCreateRequest userServiceResponse)
        {
            return _userRepository.Insert(_mapper.Map<userServiceDTO>(userServiceResponse));
        }

        public Task<bool> UpdateUserServiceResponse(userServiceUpdateRequest userServiceResponse)
        {
            return _userRepository.Update(_mapper.Map<userServiceDTO>(userServiceResponse));
        }


    }
}
