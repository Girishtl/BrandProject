using AutoMapper;
using EasyTaskMangmentDomain.Handler;
using EasyTaskMangmentDomain.Infra.Repository;
using EasyTaskMangmentDomain.Models.DTO;
using EasyTaskMangmentDomain.Models.Request;
using EasyTaskMangmentDomain.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTaskMangmentApplication.Handler
{
    public class MeetingHandler : IMeetingHandler
    {

        private IMeetingRepository _leadRepository;

        private IMapper _mapper { get; set; }

        public MeetingHandler
(IMeetingRepository userRepository, IMapper mapper)
        {
            _leadRepository = userRepository;
            _mapper = mapper;

        }

        public async Task<List<MeetingResponse>> GetAllActiveMeet()
        {
            List<MeetingResponse> lst = _mapper.Map<List<MeetingResponse>>(await _leadRepository.GetAllActive());
            return lst;
        }

        public async Task<int> InsertMeet(CreateMeetingRequest createUser)
        {
            return await _leadRepository.Insert(_mapper.Map<MeetingDTO>(createUser));


        }

        public async Task<bool> UpdateMeet(UpdateMeetingRequest updateUserRequest)
        {
            return await _leadRepository.Update(_mapper.Map<MeetingDTO>(updateUserRequest));
        }

        public async Task<bool> DeleteMeet(int id)
        {
            return await _leadRepository.Delete(id);
        }


    }
}
