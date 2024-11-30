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
    public  class LeadsHandler : ILeadsHandler
    {

        private ILeadsRepository  _leadRepository;

        private IMapper _mapper { get; set; }


         public  LeadsHandler
(ILeadsRepository userRepository, IMapper mapper)
        {
            _leadRepository = userRepository;
            _mapper = mapper;

        }

        //public async Task<List<LeadsResponse>> GetAllActiveLeads()
        //{
        //    List<LeadsResponse> lst = _mapper.Map<List<LeadsResponse>>(await _leadRepository.GetAllActive());
        //    return lst;
        //}

        //public async Task<int> InsertLeads(CreateLeadRequest createUser)
        //{
        //    return await _leadRepository.Insert(_mapper.Map<LeadDTO>(createUser));


        //}

        //public async Task<bool> UpdateLeads(UpdateLeadRequest updateUserRequest)
        //{
        //    return await _leadRepository.Update(_mapper.Map<LeadDTO>(updateUserRequest));
        //}

        //public async Task<bool> DeleteLeads(int id)
        //{
        //    return await _leadRepository.Delete(id);
        //}

    }
}
